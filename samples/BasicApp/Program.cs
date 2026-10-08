namespace BasicApp;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
#if NET8_0_WINDOWS
        ApplicationConfiguration.Initialize();
#else
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
#endif
        Application.Run(new MainWindow());
    }
}
