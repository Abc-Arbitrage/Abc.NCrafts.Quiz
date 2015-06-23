using System;
using System.Collections.Generic;

namespace Abc.NCrafts.Quizz
{
    public static class Logger
    {
        public static bool Enabled { get; set; }

        public static void Log(string s)
        {
            if (Enabled)
                Console.WriteLine(s);
        }

        public static void Log<T>(string format, T arg0)
        {
            if (Enabled)
                Console.WriteLine(format, arg0);
        }

        public static void Log(string format, IEnumerable<int> arg0)
        {
            if (Enabled)
                Console.WriteLine(format, string.Join(", ", arg0));
        }
    }
}