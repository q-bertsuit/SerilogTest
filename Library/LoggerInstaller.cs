using Serilog;


namespace Library
{
    static public class LoggerInstaller
    {
        static public Serilog.Core.Logger Install()
        {
            //SelfLog.Enable(Console.Error);

            string logFileName = "MyLog.log";

            var config = new LoggerConfiguration()
                                .ReadFrom.AppSettings()
                                .WriteTo.File(logFileName, rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true, fileSizeLimitBytes: 50000)
                                .CreateLogger();

            Log.Logger = config;

            return config;
        }

    }
}
