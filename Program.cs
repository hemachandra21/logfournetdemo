using System;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace logfournetdemo
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            log.Debug("this is debug");
            log.Info("this is information");
            log.Warn("this is warning");
            log.Error("this is error");
            log.Fatal("this is fatal");

            Console.WriteLine("Hello World!");

            prilev obj = new prilev();
            obj.Getlog();

        }
    }
}
