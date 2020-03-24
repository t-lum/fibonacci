using System;
using System.Threading;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var ended = false;

            do
            {
                Console.WriteLine("Welcome to Fibonacci console program");
                Console.Write("Digit a number to sequence: ");

                var readed = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(readed, out int number))
                {
                    var r = 0;
                    var old = 1;

                    Console.Write("Fibonacci's serie: ");

                    for (int i = 0; i < number; i++)
                    {
                        Thread.Sleep(500);

                        if (i == 0)
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            var old2 = old;

                            old = r;

                            r += old2;

                            Console.Write($"{r} ");
                        }
                    }

                    Console.WriteLine();

                    ended = true;
                }
                else
                {
                    Console.Clear();

                    Console.Write("Please digit a correct number!");
                    Console.ReadKey();

                    Console.Clear();
                }
            }
            while (!ended);

            // End of program
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
