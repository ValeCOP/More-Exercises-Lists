using System;
using System.Collections.Generic;
using System.Linq;
 
namespace _4.Mixed_Up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
             List<int> list1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> margeList = new List<int>();
            List<int> finalList = new List<int>();
            if (list.Count > list1.Count)
            {
                for (int i = 0; i <= list1.Count -1; i++)
                {
                    margeList.Add(list[i]);
                    margeList.Add(list1[list1.Count - 1- i]);

                }
                int max = Math.Max(list[list.Count -2], list[list.Count - 1]);
                int min = Math.Min(list[list.Count -2], list[list.Count - 1]);
                foreach (var item in margeList)
                {
                    if (item > min && item < max )
                    {
                        finalList.Add(item);

                    }

                }

            }
            if (list.Count < list1.Count)
            {
                for (int i = 0; i <= list.Count -1; i++)
                {
                    margeList.Add(list[i]);
                    margeList.Add(list1[list1.Count - 1- i]);

                }
                int max = Math.Max(list1[0], list1[1]);
                int min = Math.Min(list1[0], list1[1]);
                foreach (var item in margeList)
                {
                    if (item > min && item < max )
                    {
                        finalList.Add(item);

                    }

                }

            }

            var  finalList1 = finalList.OrderBy(x => x);
            Console.WriteLine(String.Join(" ", finalList1));

            

        }
    }
}