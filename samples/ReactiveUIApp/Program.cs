using ReactiveUIApp.Views;

namespace WinFormsApp1ReactiveUIApp;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
#if NET8_0_WINDOWS
        ApplicationConfiguration.Initialize();
#else
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
#endif
        Application.Run(new MainView());
    }
}
