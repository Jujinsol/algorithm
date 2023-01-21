using System;
using System.Data;
using System.Text;

class Program
{
    static int Fact(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        return num * Fact(num - 1);
    }

    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        sw.WriteLine(Fact(N));
    }
}