using aoc_2025.day1;

namespace aoc_2025;

public class Program
{
    public static void Main(string[] args)
    {
        var days = new IDay[]
        {
        };

        foreach (IDay day in days)
        {
            day.Part1();
            day.Part2();
        }
    }
}