using note_signing_app;

namespace note_signing_app { 
public partial class App : Application
{
    public App ()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow (IActivationState activationState)
    {
        var window = new Window(new AppShell());

        // Define o título (opcional)
        window.Title = "";

#if WINDOWS
        window.HandlerChanged += (s, e) => 
        {
            var nativeWindow = window.Handler.PlatformView as Microsoft.UI.Xaml.Window;
            if (nativeWindow != null)
            {
                var windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
                var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

                // Em vez de FullScreen, usamos o Presenter de sobreposição
                var presenter = appWindow.Presenter as Microsoft.UI.Windowing.OverlappedPresenter;
                
                if (presenter != null)
                {
                    // Isso mantém os botões de minimizar e fechar
                    presenter.Maximize(); 
                }
            }
        };
#endif


            return window;
    }
}
    }