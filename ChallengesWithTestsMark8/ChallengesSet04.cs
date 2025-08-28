using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           
            var result = 0;
            
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    result += n;
                }
                else
                {
                    result -= n;
                }
            };
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<string>(){str1, str2, str3, str4};
            var shortest = strings.OrderBy(s => s.Length).First();
            return shortest.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.OrderBy(s => s).First();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1 ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null){return false;}
            return Regex.IsMatch(input, @"^-?\d+(\.\d+)?$");
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0){return true;}
            int nullCount = objs.Count(obj => obj == null);
            return nullCount > objs.Length / 2;
            
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null){return 0;}
            var evens = new List<int>();
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    evens.Add(n);
                }
            }
            if (evens.Count == 0){return 0;}
            return evens.Average();

        }

        public int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
