using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text.RegularExpressions;

namespace AOC6
{
    public class AOC6
    {
        public void DetermineLengthOfPacket()
        {
            string input = File.ReadAllText(@"D:\AoC\AOC-2022\AOC\AOC6\input.txt");
            int lengthOfPacket = 14;
            for (int i = 0; i < input.Length - lengthOfPacket; i++)
            {
                string current = input.Substring(i, lengthOfPacket);
                if (new HashSet<char>(current.ToCharArray()).Count == lengthOfPacket)
                {
                    Console.WriteLine((i + lengthOfPacket));
                }
            }
        }
    }
}