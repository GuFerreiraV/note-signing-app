using note_signing_app.Models;
using note_signing_app.Services;

namespace note_signing_app
{
    public partial class MainPage : ContentPage
    {
        private readonly NoteServices _noteService;
        private readonly SmbStorageService _smbService;
        private ConsultationNoteDTO _currentNote;

        public MainPage (NoteServices noteService, SmbStorageService smbService)
        {
            InitializeComponent();
            _noteService = noteService;
            _smbService = smbService;
        }

        private async void OnConsultarClicked (object sender, EventArgs e)
        {
            var filial = FilialEntry.Text?.Trim();
            var serie = SerieEntry.Text?.Trim();
            var nota = NotaEntry.Text?.Trim();

            if (string.IsNullOrEmpty(filial) || string.IsNullOrEmpty(serie) || string.IsNullOrEmpty(nota))
            {
                await DisplayAlertAsync("Atenção", "Preencha todos os campos.", "OK");
                return;
            }

            try
            {
                var result = await _noteService.SearchNoteAsync(filial, serie, nota);

                if (result is null)
                {
                    await DisplayAlertAsync("Não Encontrado", "Nenhuma nota encontrada", "OK");
                    HideAllResults();
                    return;
                }

                _currentNote = result;

                NumeroNotaLabel.Text = result.NoteNumber;
                NomeClienteLabel.Text = result.ClientName;
                DataEmissaoLabel.Text = FormatDate(result.DateIssue);

                ResultadoBorder.IsVisible = true;
                InformacoesUsuario.IsVisible = true;
                SignatureBorder.IsVisible = true;

                // Limpa campos do usuário ao fazer nova consulta
                NomeUsuarioEntry.Text = string.Empty;
                RgEntry.Text = string.Empty;
                SignaturePad.Lines.Clear();
                ValidateUserInfo();
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync("ERRO", $"Falha na consulta:\n{ex.Message}", "OK");
            }
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            if (_currentNote == null) return;

            try
            {
                var newRecord = new Zxo010
                {
                    ZxoFilial = _currentNote.Filial,
                    ZxoSerie = _currentNote.Serie,
                    ZxoDoc = _currentNote.NoteNumber,
                    ZxoClient = _currentNote.ClientCode,
                    ZxoLoja = _currentNote.ClientStore,
                    ZxoNome = NomeUsuarioEntry.Text.Trim(),
                    ZxoRg = RgEntry.Text.Trim(),
                    ZxoData = DateTime.Now.ToString("yyyyMMdd"),
                    ZxoHora = DateTime.Now.ToString("HH:mm:ss"),
                    DELET = " ",
                    RECDEL = 0
                };

                bool success = await _noteService.SaveSignatureAsync(newRecord);

                if (success)
                {
                    // Tira o print da tela (Formulário + Assinatura) ANTES de limpar
                    string printPath = await CaptureAndSaveScreenAsync(_currentNote);
                    
                    // Tenta enviar para o servidor
                    //string serverStatus = "Upload Pendente";
                    bool uploadOk = false;

                    if (!printPath.StartsWith("Erro") && !printPath.StartsWith("Captura"))
                    {
                        string fileName = Path.GetFileName(printPath);
                        uploadOk = await _smbService.UploadFileAsync(printPath, fileName);
                        //serverStatus = uploadOk ? "ENVIADO AO SERVIDOR ✅" : "FALHA NO UPLOAD ❌";

                        // SE ENVIOU COM SUCESSO, DELETA O LOCAL
                        if (uploadOk)
                        {
                            try { File.Delete(printPath); } catch { /* Ignora erro ao deletar */ }
                        }
                    }

                    await DisplayAlertAsync("Sucesso", $"Assinatura salva!", "OK");
                    ResetApp();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync("Erro", $"Falha ao salvar: {ex.Message}", "OK");
            }
        }

        private async Task<string> CaptureAndSaveScreenAsync(ConsultationNoteDTO note)
        {
            try
            {
                if (Screenshot.Default.IsCaptureSupported)
                {
                    var screen = await Screenshot.Default.CaptureAsync();
                    if (screen != null)
                    {
                        // Nome no padrão: Comprovante_FILIAL_NOTA_SERIE_DATAHORA.png
                        string fileName = $"{note.Filial.Trim()}{note.NoteNumber.Trim()}{note.Serie.Trim()}.png";
                        
                        // AGORA SALVA NO CACHE (Temporário)
                        string folderPath = FileSystem.CacheDirectory;

                        // CÓDIGO ANTIGO (COMENTADO PARA FUTURO) - SALVAMENTO LOCAL
                        /*
                        string folderPath = FileSystem.AppDataDirectory;
#if ANDROID
                        folderPath = Android.App.Application.Context.GetExternalFilesDir(Android.OS.Environment.DirectoryPictures)?.AbsolutePath ?? FileSystem.AppDataDirectory;
#endif
                        */

                        string filePath = Path.Combine(folderPath, fileName);

                        using (var stream = await screen.OpenReadAsync())
                        using (var fileStream = File.Create(filePath))
                        {
                            await stream.CopyToAsync(fileStream);
                        }
                        return filePath;
                    }
                }
                return "Captura não suportada";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no Print: {ex.Message}");
                return "Erro ao gerar comprovante";
            }
        }

        private void OnUserInfoChanged (object sender, TextChangedEventArgs e)
        {
            ValidateUserInfo();
        }

        private void ValidateUserInfo ()
        {
            var nomePreenchido = !string.IsNullOrWhiteSpace(NomeUsuarioEntry.Text);
            var rgPreenchido = !string.IsNullOrWhiteSpace(RgEntry.Text) && RgEntry.Text.Trim().Length == 10;
            var habilitado = nomePreenchido && rgPreenchido;

            SignaturePad.IsEnabled = habilitado;
            SignaturePad.Opacity = habilitado ? 1.0 : 0.5;
            ClearSignatureBtn.IsEnabled = habilitado;
            ClearSignatureBtn.BackgroundColor = habilitado ? Colors.Black : Colors.Gray;
            SignatureHint.IsVisible = !habilitado;

            // Atualiza a mensagem de hint conforme o erro (Original)
            if (!habilitado)
            {
                if (!nomePreenchido && !rgPreenchido)
                    SignatureHint.Text = "⚠️ Preencha Nome e RG";
                else if (!nomePreenchido)
                    SignatureHint.Text = "⚠️ Preencha o Nome";
                else if (!rgPreenchido)
                    SignatureHint.Text = "⚠️ Preencha o RG";
            }

            // Controle do botão de envio
            SubmitBtn.IsEnabled = habilitado && SignaturePad.Lines.Count > 0;
        }

        private void OnDrawingLineCompleted(object sender, EventArgs e)
        {
            // Revalida o botão de envio quando o usuário termina um traço
            var nomePreenchido = !string.IsNullOrWhiteSpace(NomeUsuarioEntry.Text);
            var rgPreenchido = !string.IsNullOrWhiteSpace(RgEntry.Text) && RgEntry.Text.Trim().Length == 10;
            
            SubmitBtn.IsEnabled = nomePreenchido && rgPreenchido && SignaturePad.Lines.Count > 0;
        }

        private void OnClearSignatureClicked (object sender, EventArgs e)
        {
            SignaturePad.Lines.Clear();
            SubmitBtn.IsEnabled = false;
        }

        private void ResetApp()
        {
            _currentNote = null;
            FilialEntry.Text = string.Empty;
            SerieEntry.Text = string.Empty;
            NotaEntry.Text = string.Empty;
            HideAllResults();
        }

        private void HideAllResults ()
        {
            ResultadoBorder.IsVisible = false;
            InformacoesUsuario.IsVisible = false;
            SignatureBorder.IsVisible = false;
        }

        private static string FormatDate (string date)
        {
            if (DateTime.TryParseExact(date, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out var data))
            {
                return data.ToString("dd/MM/yyyy");
            }
            return date;
        }        
    }
}
