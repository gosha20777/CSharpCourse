using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Contester. Created by gosha 20777.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            string processName, mode;
            if (args.Length == 2)
            {
                processName = args[0];
                mode = args[1].ToLower();
            }
            else
            {
                Console.Write("Enter program name: ");
                processName = Console.ReadLine();
                Console.Write("Enter mode [easy] [hard]: ");
                mode = Console.ReadLine().ToLower();
            }
            Console.WriteLine();
            Console.WriteLine("Testing...");
            string pathToFile = mode + ".txt";
            using (StreamReader sr = new StreamReader(pathToFile))
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    count++;
                    string input = sr.ReadLine();
                    string output = sr.ReadLine();
                    TimeSpan workingTime;
                    bool sucsess = Tester.Test(processName, input, output, 1000, out workingTime);
                    Console.Write("Test {0}\tTime {1} ms\t", count, workingTime.Milliseconds);
                    if (sucsess)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("SUCSESS!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("FAIL AZAZA!");
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
