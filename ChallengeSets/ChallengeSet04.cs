using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var answer = 0;
            if (numbers == null)
            {
                return 0;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                if(numbers[i] % 2 != 0)
                {
                    answer -= numbers[i];
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var a = new List<string>();
            a.Add(str1);
            a.Add(str2);
            a.Add(str3);
            a.Add(str4);
            int answer = str1.Length;
            for(int i = 0; i < a.Count; i++)
            {
                if(answer > a[i].Length)
                {
                    answer = a[i].Length;
                }
            }
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var answer = false;
            if (sideLength1 + sideLength2 > sideLength3)
            {
                if (sideLength2 + sideLength3 > sideLength1)
                {
                    if (sideLength1 + sideLength3 > sideLength2)
                    {
                        answer = true;
                    }
                }
            }
            return answer;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input == "")
            {
                return false;
            }
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            if (count > (objs.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            var a = new List<double>();
            double sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    a.Add(numbers[i]);
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            if(a.Count == 0)
            {
                return 0;
            }
            else
            {
                return sum / a.Count;
            }
        }

        public int Factorial(int number)
        {
            int factorial = number;
            if (factorial < 0)
            {
                throw new ArgumentOutOfRangeException("age", "All factorials must be positive.");
            }
            if (factorial == 0)
            {
                factorial = 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {
                if (i > 0)
                {
                    i = Math.Abs(i);
                }
                factorial *= i;
            }
            return factorial;
        }
    }
}
