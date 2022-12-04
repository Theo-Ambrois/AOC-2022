class Program
{
    static public void Main()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        AOC1.AOC1 AOC1 = new AOC1.AOC1();
        AOC2.AOC2 AOC2 = new AOC2.AOC2();
        AOC3.AOC3 AOC3 = new AOC3.AOC3();
        //AOC1.SortMaxCal(3);
        //AOC2.CalculateScoreMax();
        AOC3.CalculteSum();
        AOC3.CalculateSumThreeElfGroup();

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}