using System;
using SingletonPatternExample;
class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Logger log1 = Logger.Instance();
            Logger log2 = Logger.Instance();
            int i = 0;

            Console.WriteLine("Type 'exit' to stop logging!\t");

            while (true)
            {
                i++;
                Console.Write("Enter a message: ");
                string message = Console.ReadLine();

                if (i % 2 != 0)
                {
                    Console.WriteLine("Using Logger 1:");
                    log1.Logs(message);
                }
                else
                {
                    Console.WriteLine("Using Logger 2:");
                    log2.Logs(message);
                }

                Console.WriteLine();

                if (message.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    log1.Logs("Exiting utility class : " + date);
                    break;
                }
            }
        }
    }

