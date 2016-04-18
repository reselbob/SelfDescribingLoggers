using log4net;
using System;
using Reselbob.Logentries;
namespace KeyValueLogger
{
    class Program
    {
       private static readonly ILog log =
         LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        static void Main(string[] args)
        {
            //Bind to the Log4Net configuration
            log4net.Config.XmlConfigurator.Configure();
            while (true)
            {
                var msg = "Just starting up, all is well";

                log.Info(msg);

                Console.WriteLine("Strike the Enter key  to Log again. Type 'q' to exit");
                String x = System.Console.ReadLine();
                if (x.ToLower().Equals("q")) Environment.Exit(0); 
            }
            
        }
    }
}
