using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var i = vals.Length;
            if (i % 2 == 0)
            {                
                return true;
            }
            
            else                
            {
                return false;
            }
        }
    
        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int expected = str1.Length.CompareTo(str2.Length);
            if (expected < 0)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            };
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int expected = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    expected += numbers[i];
                }
                return expected;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                int expected = 0;
                foreach (var elements in numbers)
                {
                    if (elements % 2 == 0)
                    {
                        expected += elements;
                    }
                }
                return expected;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) 
            {
                return 0;
            }
            else 
            {
                return number / 2;
            }
        }
    }
}
