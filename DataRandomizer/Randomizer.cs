using System;

namespace Reselbob.Logentries
{
    public class Randomizer
    {
        private static Random _random;
        private static string[] _lastNames = { "Brown", "White", "Jones", "Smith", "Higgins", "Clay", "Warren", "Vine", "Dickens", "Gibbon" };
        private static string[] _firstNames = { "George", "William", "Robert", "John", "Benjamin", "Susan", "Jane", "Vivian", "Denise", "Glynnis" };
        private static string _alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";

        static Randomizer()
        {
            _random = new Random();
        }

        public static string GetFullName()
        {
            return GetFirstName() + " " + GetLastName();
        }


        public static string GetLastName()
        {
            var last = _random.Next(_lastNames.Length - 1);
            return _lastNames[last];
        }



        public static string GetFirstName()
        {
            var first = _random.Next(_firstNames.Length - 1);
            return _firstNames[first];
        }

        public static int GetNumber()
        {
            return _random.Next(100000);
        }

        /// <summary>
        /// Returns a random string, with a max of 100 characters
        /// </summary>
        /// <returns>a random string, with a max of 100 characters</returns>
        public static string GetString()
        {
            return GetString(100);
        }
        /// <summary>
        /// Gets a string of random alphanumerica characters
        /// </summary>
        /// <param name="maxLength">the maximum length fo the string</param>
        /// <returns>a string of random alphanumerica characters</returns>
        public static string GetString(int maxLength)
        {
            char[] bet = _alphabet.ToCharArray();
            var str = "";
            var lgth = _random.Next(maxLength);
            for (var i = 0; i < lgth; i++){
                var modSeed = _random.Next(100);
                var pos = bet.Length -1;
                var c = _random.Next(pos);
                if (modSeed % 2 == 0)
                {
                    str = str + bet[c].ToString().ToUpper();
                }
                else
                {
                    str = str + bet[c].ToString();
                }
            }

            return str;
        }
    }
}
