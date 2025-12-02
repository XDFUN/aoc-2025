using System.Runtime.CompilerServices;

namespace aoc_2025.day1;

public class Day1 : IDay
{
    private static readonly string s_inputPath = Path.GetFullPath(Path.Combine(".", "day1", "input.txt"));

    public void Part1()
    {
        using FileStream fileStream = File.OpenRead(s_inputPath);
        using TextReader reader = new StreamReader(fileStream);

        const int dialSize = 100;
        var dial = 50;
        var zeroCount = 0;

        for (string? line = reader.ReadLine(); line is not null; line = reader.ReadLine())
        {
            ReadOnlySpan<char> lineSpan = line.AsSpan();
            int direction = Unsafe.As<char, ushort>(ref Unsafe.AsRef(in lineSpan[0]));
            int sign = ((direction - 86) % 4) + 1;
            int rawRotation = int.Parse(lineSpan[1..].ToString()) % dialSize;
            int rotation = dialSize + (sign * rawRotation);
            dial = (dial + rotation) % dialSize;
            zeroCount -= 1 / ~dial;
        }

        Console.WriteLine(zeroCount);
    }

    public void Part2() { }
}