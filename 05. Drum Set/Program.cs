using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> backUp = new List<int>(drums);

            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                ushort hitPower = ushort.Parse(command);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= hitPower;
                }
                if (drums.Min() <= 0)
                {
                    for (int i = 0; i < drums.Count; i++)
                    {
                        if (drums[i] <= 0)
                        {
                            var pay = backUp[i] * 3;
                            savings -= pay;
                            if (savings > 0)
                            {
                                drums[i] = backUp[i];

                            }
                            else
                            {
                                savings += pay;
                            }
                            

                        }

                    }

                    
                }
             

            }
            List<int> result = drums.Where(drum => drum > 0).ToList();
            Console.WriteLine(String.Join(" ", result));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");

                   
        }
    }
}
