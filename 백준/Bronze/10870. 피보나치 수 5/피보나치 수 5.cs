using System;

class Program
{
    static int Py(int num)
    {
        if (num == 0)
            return 0;
        if (num == 1)
            return 1;

        return Py(num - 2) + Py(num - 1);        
    }

    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        
        sw.WriteLine(Py(N));
    }
}