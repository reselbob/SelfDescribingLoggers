﻿using log4net;
using System;
using Reselbob.Logentries;
using Newtonsoft.Json;

namespace JsonLogger
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
                var data = new
                {
                    FirstName = Randomizer.GetFirstName(),
                    LastName = Randomizer.GetLastName(),
                    Company = "Tik Tik Technologies",
                    Division = "DevOps",
                    Entered = DateTime.UtcNow,
                    Comment = Randomizer.GetString()

                };

                string json = JsonConvert.SerializeObject(data);

                log.Info(json);

                Console.WriteLine(json);
                Console.WriteLine("");
                Console.WriteLine("Strike the Enter key  to Log again. Type 'q' to exit");

                String x = System.Console.ReadLine();
                if (x.ToLower().Equals("q")) Environment.Exit(0);
            }
        }

    }
 }