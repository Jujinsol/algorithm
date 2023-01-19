using System;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        List<(int, string)> list = new List<(int, string)>();

        for (int i = 0; i < N; i++)
        {
            string[] s = sr.ReadLine().Split();
            list.Add((int.Parse(s[0]), s[1]));
        }

        list = list.OrderBy(x => x.Item1).ToList();

        for (int i = 0; i < N; i++)
        {
            sw.Write($"{list[i].Item1} ");
            sw.WriteLine($"{list[i].Item2}");
        }
    }
}