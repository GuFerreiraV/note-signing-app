using SMBLibrary;
using SMBLibrary.Client;
using System.Net;

namespace note_signing_app.Services
{
    public class SmbStorageService
    {
        // =========================================================
        // CONFIGURAÇÕES DO SERVIDOR (PREENCHA AQUI)
        // =========================================================
        private const string SERVER_IP = " "; // IP do seu servidor onde está o drive E:
        private const string USERNAME = " ";      // Usuário do Windows/AD com permissão de escrita
        private const string PASSWORD = " ";      // Senha do usuário
        private const string SHARE_NAME = "App_Assinaturas_NFs"; // O NOME DO COMPARTILHAMENTO (Não é o caminho E:\...)
        private const string SUBFOLDER = "comprovantes"; // A subpasta dentro do compartilhamento
        // =========================================================

        public async Task<bool> UploadFileAsync(string localFilePath, string remoteFileName)
        {
            return await Task.Run(() =>
            {
                SMB2Client client = new SMB2Client();
                bool isConnected = client.Connect(IPAddress.Parse(SERVER_IP), SMBTransportType.DirectTCPTransport);

                if (!isConnected)
                {
                    Console.WriteLine("Falha ao conectar no servidor SMB");
                    return false;
                }

                try
                {
                    NTStatus status = client.Login(string.Empty, USERNAME, PASSWORD);
                    if (status != NTStatus.STATUS_SUCCESS)
                    {
                        Console.WriteLine($"Falha no Login SMB: {status}");
                        return false;
                    }

                    ISMBFileStore fileStore = client.TreeConnect(SHARE_NAME, out status);
                    if (status != NTStatus.STATUS_SUCCESS)
                    {
                        Console.WriteLine($"Falha ao acessar compartilhamento '{SHARE_NAME}': {status}");
                        return false;
                    }

                    // Lê o arquivo local
                    byte[] fileBytes = File.ReadAllBytes(localFilePath);

                    // Cria o caminho remoto (Ex: comprovantes\arquivo.png)
                    string remotePath = Path.Combine(SUBFOLDER, remoteFileName);

                    object fileHandle;
                    FileStatus fileStatus;

                    // Cria o arquivo no servidor
                    status = fileStore.CreateFile(
                        out fileHandle,
                        out fileStatus,
                        remotePath,
                        AccessMask.GENERIC_WRITE | AccessMask.SYNCHRONIZE,
                        SMBLibrary.FileAttributes.Normal,
                        ShareAccess.None,
                        CreateDisposition.FILE_OVERWRITE_IF,
                        CreateOptions.FILE_NON_DIRECTORY_FILE,
                        null);

                    if (status != NTStatus.STATUS_SUCCESS)
                    {
                        Console.WriteLine($"Falha ao criar arquivo remoto '{remotePath}': {status}");
                        return false;
                    }

                    // Escreve os dados
                    int bytesWritten;
                    status = fileStore.WriteFile(out bytesWritten, fileHandle, 0, fileBytes);

                    fileStore.CloseFile(fileHandle);
                    fileStore.Disconnect();
                    client.Logoff();

                    return status == NTStatus.STATUS_SUCCESS;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro crítico SMB: {ex.Message}");
                    client.Disconnect();
                    return false;
                }
            });
        }
    }
}
