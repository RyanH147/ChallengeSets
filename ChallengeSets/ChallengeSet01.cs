using System;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2) // Refactored = return num1 == num2;
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double expectedDifference = minuend -= subtrahend;
            {
                return expectedDifference;
            }
        }

        public int Add(int number1, int number2)
        {
            int expectedSum = number1 += number2;
            {
                return expectedSum;
            }
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            long product = factor1 *= factor2;
            {
                return product;
            }
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "") //Refactored = return (nameOfPerson == "") ? "Hello!" : $"Hello, {nameOfPerson}!";
            {
                return "Hello!";
            }
            return $"Hello, {nameOfPerson}!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
