namespace AOC1
{
    public class Elf
    {
        public List<int> CalculateCals()
        {
            int cal = 0;
            List<int> cals = new List<int>();

            foreach (string line in System.IO.File.ReadLines(@"D:\AoC\AOC-2022\AOC1\AOC1\elf.txt"))
            {
                if (line != string.Empty)
                {
                    cal =+ Int32.Parse(line);
                }
                else if (line == string.Empty)
                {
                    cals.Add(cal);
                    cal = 0;
                }
            }        
            return cals;
        }

        public int SortMaxCal(int numberOfElfs)
        {
            int sum = 0;
            List<int> cals = new List<int>();
            cals = CalculateCals();

            for(int i = 0; i < numberOfElfs; i++)
            {
                int max = cals.Max();
                Console.WriteLine(max.ToString());
                sum =+ max;
                cals.Remove(max);
            }

            Console.WriteLine(sum.ToString());
            return sum;
        }
    }
}