using AOC1;

class Program
{

    static public void Main()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        Elf elf = new Elf();
        elf.SortMaxCal(3);

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}