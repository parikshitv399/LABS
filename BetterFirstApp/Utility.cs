using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterFirstApp
{
    public class Utility
    {
        public static Int32 Add(Int32 num1, Int32 num2)
        {
            return num1 + num2;
        }
        public static Int32 Sub(Int32 num1, Int32 num2)
        {
            return num1 - num2;
        }
        public static Int32 Mul(Int32 num1, Int32 num2)
        {
            return num1 * num2;
        }
        public static float Div(Int32 num1, Int32 num2)
        {
            return num1 / num2;
        }
        public static Int32 Increment(Int32 num = 0) //Optional Parameter
        {
            num += 1;
            num++;
            return num;
        }
        public static Boolean IsEmpty(string? str, int? num)//string Indication (str can accept null)
        {
            return String.IsNullOrEmpty(str) || num == null;
        }
        public static string[] GetNames()
        {
            //string[] names = new string[3];
            //names[0] = "Parikshit";
            //names[1] = "Rohit";
            //names[2] = "Anupma";
            string[] names = new string[] { "Parikshit", "Rohit", "Anupma" };
            return names;
        }
        public static int[] GetNumbers()
        {
            int[] nums = new int[] { 1, 2, 3 };
            return nums;
        }
        public static void GetWordCount(string[] strArray) //passing array as parameter
        {
            Console.WriteLine($"strArray has {strArray.Length} items in it");
        }
        public static void CreateSentence(params string[] strs)
        {
            string sentence = string.Empty;
            foreach (var item in strs)
            {
                sentence += $" {item}";
            }
            Console.WriteLine(sentence);
        }
    }
}
