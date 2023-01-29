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
        HashSet<string> NS = new HashSet<string>();
        
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            NS.Add(sr.ReadLine());
        }

        for (int i = 0; i < M; i++)
        {
            if (NS.Contains(sr.ReadLine()))
                count++;
        }

        sw.WriteLine(count);
    }
}