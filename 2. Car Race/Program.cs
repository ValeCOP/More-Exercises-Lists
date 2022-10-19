using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            double firstCartime = 0.0;
            double secondCartime = 0.0;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                firstCartime += numbers[i];
                if (numbers[i] == 0)
                {
                    firstCartime *= 0.8;
                }
                
            }
             for (int i = numbers.Length -1; i > numbers.Length / 2; i--)
            {
                secondCartime += numbers[i];
                if (numbers[i] == 0)
                {
                    secondCartime *= 0.8;
                }
                
            }
            if (firstCartime < secondCartime)
            {
                Console.WriteLine($"The winner is left with total time: {firstCartime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondCartime}");
            }

        }
    }
}
