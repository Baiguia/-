using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Equation
{
    public class Formula
    {
        //private int FractionOfMam { get; set; }

        //private int FractionOfSon { get; set; }

        public List<string> Exercises = new List<string>();
        public List<string> Answers = new List<string>();

        /*public string CreateNumber(int Max)
        {
            string result = string.Empty;
            int mam = new Random().Next(Max + 1);
            Thread.Sleep(500);
            int son = new Random().Next(Max + 1);

            while (mam == 0 || son == 0)
            {
                mam = new Random().Next(Max + 1);
                son = new Random().Next(Max + 1);
            }

            if (mam == 1)
            {
                result = son.ToString();
            }
            else if (son > mam)
            {
                if (son % mam == 0)
                {
                    result = (son / mam).ToString();
                }
                else
                {
                    int b = son % mam;//b=1 son=5 mam=2    2'1/2
                    result = (int)(son/mam) + "'" + (son % mam) + "/" + mam;
                }
            }
            else if (son == mam)
            {
                result = "1";
            }
            else
            {
                result = son.ToString() + "/" + mam.ToString();
            }
            return result;
        }*/

        public void GetEquations(int Max)
        {
            int Count = IsValidCount();
            int HowOperator = IsValidOperators();
            StringBuilder Sbder = new StringBuilder();
            DataTable dt = new DataTable();
            string[] Operator = { "+", "-", "×", "÷" };

            for (int i = 0; i < Count; i++)
            {
                Sbder.Clear();
                for (int j = 0; j < HowOperator + 1; j++)
                {
                    int Num = new Random().Next(Max + 1);

                    if (Sbder.Length != 0 && Sbder[Sbder.Length - 1] == '÷')
                    {
                        Num = new Random().Next(1, Max + 1);
                    }
                    
                    int Index = new Random().Next(4);
                    string result = string.Empty;
                    result = j == HowOperator ? Num.ToString() : Num + Operator[Index];
                    Sbder.Append(result);
                    Thread.Sleep(300);
                }
                AddExercisesAndAnswers(Sbder, dt);
            }
        }


        private int IsValidCount()
        {
            Console.WriteLine("请输入出题的数量：");
            int count = int.Parse(Console.ReadLine());
            if (count > 10000 || count <= 0)
            {
                Console.WriteLine("不支持该出题量，请重新输入");
                IsValidCount();
            }
            return count;
        }


        private int IsValidOperators()
        {
            Console.WriteLine("请输入出现运算符的数量(不超过3个)：");
            try
            {
                int between = int.Parse(Console.ReadLine());
                if (between > 3 || between <= 0)
                {
                    Console.WriteLine("不支持该运算符个数，请重新输入");
                    IsValidOperators();
                }
                return between;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        
        private void AddExercisesAndAnswers(StringBuilder Sbder,DataTable dt)
        {
            Exercises.Add(Sbder.ToString() + "=");
            Sbder.Replace('×', '*');
            Sbder.Replace('÷', '/');
            Answers.Add(dt.Compute(Sbder.ToString(), "").ToString());
        }
    }
}
