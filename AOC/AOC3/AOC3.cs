using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks.Sources;

namespace AOC3
{
    public class AOC3
    {
        

        public int CalculteSum()
        {
            int sum = 0;
            List<string> priorities = new List<string>();
            foreach (string line in File.ReadAllLines(@"D:\AoC\AOC-2022\AOC\AOC3\input.txt"))
            {
                var first = line.Substring(0, (line.Length / 2));
                var last = line.Substring((line.Length / 2), (line.Length / 2));

                byte[] fistBytes = Encoding.ASCII.GetBytes(first);
                byte[] lastBytes = Encoding.ASCII.GetBytes(last);

                priorities.Add(Encoding.ASCII.GetString(fistBytes.Intersect(lastBytes).ToArray()));
                sum += CalculatePriority(priorities);

            }
            return sum;
        }

        public int CalculateSumThreeElfGroup()
        {
            List<string> groupOfRucksacks = new List<string>();
            List<string> priorities = new List<string>();
            foreach (string line in File.ReadLines(@"D:\AoC\AOC-2022\AOC\AOC3\input.txt"))
            {
                groupOfRucksacks.Add(line);
                if (groupOfRucksacks.Count == 3)
                {
                    byte[] fistBytes = Encoding.ASCII.GetBytes(groupOfRucksacks.ElementAt(0));
                    byte[] secoundByters = Encoding.ASCII.GetBytes(groupOfRucksacks.ElementAt(1));
                    byte[] thirdBydes = Encoding.ASCII.GetBytes(groupOfRucksacks.ElementAt(2));

                    priorities.Add(Encoding.ASCII.GetString(fistBytes.Intersect(secoundByters).Intersect(thirdBydes).ToArray()));

                    groupOfRucksacks.Clear();
                }
            }

            return CalculatePriority(priorities);
        }

        public int CalculatePriority(List<string> priorities)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int sum = 0;
            foreach (string priority in priorities)
            {
                char letter = char.Parse(priority);

                if (Char.IsUpper(letter))
                {
                    sum += 26;
                }

                letter = char.ToLower(letter);
                sum = sum + letters.IndexOf(letter) + 1;
            }
            Console.WriteLine(sum);
            return sum;

        }
    }
}