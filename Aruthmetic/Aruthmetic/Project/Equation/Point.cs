using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class Print
    {
        /// <summary>
        /// 存储题目 
        /// </summary>
        /// <param name="Exercises">题目集</param>
        public static void PrintExercise(List<string> Exercises)
        {
            if (Exercises == null) return;
            string ExercisePath = Directory.GetCurrentDirectory() + @"\Exercise.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(ExercisePath, false, Encoding.Default))
                {
                    sw.Flush();
                    int i = 0;
                    foreach (var item in Exercises)
                    {
                        i++;
                        sw.WriteLine($"{i}、{item}");
                    }
                    sw.Close();
                }
                Console.WriteLine("生成题目完毕！！！");
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// 存储答案
        /// </summary>
        /// <param name="Answers">答案集</param>
        public static void PrintAnwer(List<string> Answers)
        {
            if (Answers == null) return;
            string AnswerPath = Directory.GetCurrentDirectory() + @"\Answer.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(AnswerPath, false, Encoding.Default))
                {
                    sw.Flush();
                    int i = 0;
                    foreach (var item in Answers)
                    {
                        i++;
                        sw.WriteLine($"{i}、{item}");
                    }
                    sw.Close();
                }
                Console.WriteLine("生成答案完毕！！！");
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
