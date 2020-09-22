using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_and_operations_level_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First value here");
            string num1 = Console.ReadLine();
                Console.WriteLine("Second value here");
                string num2 = Console.ReadLine();
                int trunum1 = Convert.ToInt32(num1);
                int trunum2 = Convert.ToInt32(num2);
                Console.WriteLine("Operation here");
                string operation = Console.ReadLine();
            string multiply = "*";
            string divide = "/";
            string add = "+";
            string subtract = "-";
            if (operation == multiply)
            {
                Console.WriteLine(trunum1 * trunum2);
            }
            else if (operation == divide)
            {
                Console.WriteLine(trunum1 / trunum2);
            }
            else if (operation == add)
            {
                Console.WriteLine(trunum1 + trunum2);
            }
            else if (operation == subtract)
            {
                Console.WriteLine(trunum1 - trunum2);
                    }
            else
            {
                Console.WriteLine(">:(");
                Console.WriteLine("Why");
                }
            Console.ReadLine();
            
        }
    }
}
