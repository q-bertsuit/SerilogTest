using Serilog;
using System;
using Library;
    
namespace SerilogTest
{
    class Program
    {
        private static readonly ILogger Logger = Log.ForContext(typeof(Program));

        static void Main(string[] args)
        {
            LoggerInstaller.Install();

            Logger.Information("It works!");

            Console.ReadLine();
        }
    }
}
