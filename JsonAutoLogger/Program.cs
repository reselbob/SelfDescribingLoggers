using log4net;
using Newtonsoft.Json;
using System;

namespace JsonAutoLogger
{
    class Program
    {
        private static readonly ILog log =
          LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            while (true)
            {
                var msg = new
                {
                    Phase = "Application Startup",
                    Entered = DateTime.UtcNow,
                    Comment = "All is well"

                };

                log.Info(JsonConvert.SerializeObject(msg));

                Console.WriteLine("");
                Console.WriteLine("Strike the Enter key  to Log again. Type 'q' to exit");

                String x = System.Console.ReadLine();
                if (x.ToLower().Equals("q")) Environment.Exit(0);
            }
        }
    }
}
