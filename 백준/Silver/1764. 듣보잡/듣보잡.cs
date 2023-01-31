using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        string[] s = sr.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);

        var Ns = Enumerable.Range(0, N)
            .Select(_ => sr.ReadLine())
            .ToArray();

        var Ms = Enumerable.Range(0, M)
            .Select(_ => sr.ReadLine())
            .ToArray();

        int count = 0;
        foreach (var ss in Enumerable.Intersect(Ns, Ms).OrderBy(x => x))
            count++;
        sw.WriteLine(count);
        foreach (var ss in Enumerable.Intersect(Ns, Ms).OrderBy(x => x))
            sw.WriteLine(ss);
    }
}