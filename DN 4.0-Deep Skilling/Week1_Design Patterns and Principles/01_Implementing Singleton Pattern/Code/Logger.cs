using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger? instance;
        private int i = 0;
        private Logger()
        {
            Console.WriteLine("Logging utility class is initialized");
        }
        public static Logger Instance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Logs(string message)
        {
            i += 1;
            Console.WriteLine("Log " + i + ":" + message);
        }
    }
}