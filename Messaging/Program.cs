using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>  numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string message = Console.ReadLine();
            string pass;
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = GetSum(numbers, i);
                int countIndex = GetChar(message, sum);

                char currentChar = message[countIndex];
                string newMessage = message.Remove(countIndex, 1);
                message = newMessage;
                Console.Write(currentChar);
            }



        }

        private static int GetChar(string message, int sum)
        {
            int countIndex = 0;

            for (int j = 0; j < sum; j++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }

            return countIndex;
        }

        private static int GetSum(List<int> numbers, int i)
        {
            int sum = 0;
            int tempNiumber = numbers[i];
            while (tempNiumber != 0)
            {
                int num = tempNiumber % 10;
                sum += num;
                tempNiumber /= 10;
            }

            return sum;
        }
    }
}
