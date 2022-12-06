using System.Collections.Generic;
using System.Collections.Immutable;

namespace AOC4
{
    public class AOC4
    {
        public int amountOfPairs()
        {

            var assignedSections = File.ReadLines(@"D:\AoC\AOC-2022\AOC\AOC4\input.txt").ToList();
            var sum = 0;
            assignedSections.ForEach(pair =>
            {
                var sectionRanges = ParseSections(pair).ToImmutableArray();
                if (IsOverlapping(sectionRanges[0], sectionRanges[1]))
                {
                    sum++;
                }
            });

            Console.WriteLine(sum.ToString());
            //return sum;

            sum = 0;

            assignedSections.ForEach(pair =>
            {
                var sectionRanges = ParseSections(pair).ToImmutableArray();
                if (IsIntersecting(sectionRanges[0], sectionRanges[1])) sum++;
            });

            Console.WriteLine(sum.ToString());
            return sum;

        }

        IEnumerable<Range> ParseSections(string assignmentPair)
        {
            return assignmentPair.Split(',').Select(GetRange).ToList();
        }

        Range GetRange(string assignmentPair)
        {
            var sections = assignmentPair.Split('-').Select(int.Parse).ToArray();
            return new Range(sections[0], sections[1]);
        }

        bool IsOverlapping(Range startRange, Range endRange)
        {
            return (startRange.Start.Value <= endRange.Start.Value && startRange.End.Value >= endRange.End.Value) || (endRange.Start.Value <= startRange.Start.Value && endRange.End.Value >= startRange.End.Value);
        }

        bool IsIntersecting(Range startRange, Range endRange)
        {
            return startRange.Start.Value <= endRange.End.Value && endRange.Start.Value <= startRange.End.Value;
        }

    }
}