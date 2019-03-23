using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;
using Equation;

namespace CreateFourItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Formula fc = new Formula();
            WriteLine("请输入运算数据的范围：");
            int Max = int.Parse(ReadLine());
            fc.GetEquations(Max);
            Print.PrintExercise(fc.Exercises);
            Print.PrintAnwer(fc.Answers);
            ReadKey();
        }
    }
}
