using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddValues("test1", "test2", "test3"));
            int[] randomNums = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(SumArray(randomNums));
        }
        public static string AddValues(string str1, string str2, string str3)
        {

            List<string> newStrings = new List<string>();
            newStrings.Add(str1);
            newStrings.Add(str2);
            newStrings.Add(str3);


            return newStrings.ToString();
            
        }


        static int SumArray(int[] x)
        {
            int newTotal = x.Sum();
            return newTotal;

        }

        public static int RemoveNum(List<int> nums, int y)
        {
            if (nums.Contains(y))
            {
                nums.Remove(y);
                return nums;
            }
            else
            {
                return 0;
            }


        }

        static List<string> AddToList(string[] fruits)
        {
            string[] fruit = new string[] { "grapes", "oranges" };
            List<string> fruitList = fruits.ToList();

            return fruitList;

        }

        static int TryMe(int x, int y)
        {

            
            try
            {
                int divide = x / y;
                int result = divide;
                return result;
            }
            catch (ArithmeticException)
            {
                return 9;
            }


        }
    }
}
