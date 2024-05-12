using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Question
    {
        public static void question1(string str)
        {
            while (str != "y" && str != "n")
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.Write("Enter correct input: ");
                str = Console.ReadLine();
            }
        }

        public static string question2(string str)
        {
            while (str != "1" && str != "2" && str != "3")
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.Write("Enter correct input: ");
                str = Console.ReadLine();
            }

            return str;
        }
    }
}
