using Reselbob.Logentries;
using System;

namespace JsonAutoLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var data = new
                {
                    FirstName = Randomizer.GetFirstName(),
                    LastName = Randomizer.GetLastName(),
                    Company = "Tik Tik Technologies",
                    Division = "Development",
                    Entered = DateTime.UtcNow,
                    Comment = Randomizer.GetString()

                };

                Reselbob.Logentries.JsonLogger.Log(data, LogLevel.Warn);

                Console.WriteLine("");
                Console.WriteLine("Strike the Enter key  to Log again. Type 'q' to exit");

                String x = System.Console.ReadLine();
                if (x.ToLower().Equals("q")) Environment.Exit(0);
            }
        }
    }
}
