using System;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        List<(int, int)> list = new List<(int, int)>();

        for (int i = 0; i < N; i++)
        {
            string[] s = sr.ReadLine().Split();            
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            list.Add((y, x));
        }
        list.Sort();

        for (int i = 0; i < N; i++)
        {
            sw.Write($"{list[i].Item2} ");
            sw.WriteLine($"{list[i].Item1}");
        }
    }
}