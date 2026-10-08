using System.Globalization;

namespace BasicApp;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        if (args.Length > 0)
            CultureInfo.CurrentUICulture = new CultureInfo(args[0]);

#if NET8_0_WINDOWS
        ApplicationConfiguration.Initialize();
#else
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
#endif
        Application.Run(new MainWindow());
    }
}
