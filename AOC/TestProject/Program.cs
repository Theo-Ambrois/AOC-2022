class Program
{
    static public void Main()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        AOC1.AOC1 AOC1 = new AOC1.AOC1();
        AOC2.AOC2 AOC2 = new AOC2.AOC2();
        AOC3.AOC3 AOC3 = new AOC3.AOC3();
        AOC4.AOC4 AOC4 = new AOC4.AOC4();
        AOC5.AOC5 AOC5 = new AOC5.AOC5();
        AOC6.AOC6 AOC6 = new AOC6.AOC6();
        //AOC1.SortMaxCal(3);
        //AOC2.CalculateScoreMax();
        //AOC3.CalculteSum();
        //AOC3.CalculateSumThreeElfGroup();
        //AOC4.amountOfPairs();
        //AOC5.CratesOnTop();
        AOC6.DetermineLengthOfPacket();

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}