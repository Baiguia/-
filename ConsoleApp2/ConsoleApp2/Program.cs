using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();          
            string[] op = new string[] { "＋", "－", "×", "÷" };
            for (int i = 0; i < 10; i++)
            {
                double number1 = number.Next(1, 10);
                double number2 = number.Next(1, 10);
                int opnext = number.Next(0, 5);
                double s = 0;
                switch (opnext)
                {
                    case 0:
                        s = number1 + number2;
                        break;
                    case 1:
                        s = number1 - number2;
                        break;
                    case 2:
                        s = number1 * number2;
                        break;
                    case 3:
                        s = number1 / number2;
                        break;
                }
                Console.WriteLine(number1 + op[opnext] + number2 + "=" + s);
            }
            Console.ReadKey();
        }


    }
}
