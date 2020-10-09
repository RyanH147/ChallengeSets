using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return true;
            }

            else
            {
                foreach (var elements in vals)
                {
                    if (elements == false)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                return numbers.Sum() % 2 != 0;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var containsNumber = false;
            var containsUpper = false;
            var containsLower = false;

            foreach (char c in password)
            {
                if (Char.IsNumber(c))
                {
                    containsNumber = true;
                }

                if (Char.IsLower(c))
                {
                    containsLower = true;
                }

                if (Char.IsUpper(c))
                {
                    containsUpper = true;
                }
            }

            if (containsNumber && containsLower && containsUpper)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public char GetFirstLetterOfString(string val)
        {
            var Firstletter = val[0];
            return Firstletter;
        }

        public char GetLastLetterOfString(string val)
        {
            var Lastletter = val[val.Length - 1];
            return Lastletter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                var expected = (dividend / divisor);
                return expected;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            var expected = nums[nums.Length -1] - nums[0];
            return expected;
        }
        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i <= 100; i++)
            {
                if(i %2 != 0)
                {
                    numbers.Add(i);
                }
            }
            int[] numbers1 = new int[numbers.Count];
            for(int j = 0; j < numbers.Count; j++)
            {
                numbers1[j] = numbers[j];
            }
            return numbers1;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
