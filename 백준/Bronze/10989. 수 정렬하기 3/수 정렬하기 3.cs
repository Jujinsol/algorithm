using System;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        int[] arr = new int[10001];

        for (int i = 0; i < N; i++)
            arr[int.Parse(sr.ReadLine())]++;

        for (int i = 0; i <= 10000; i++)
        {
            if (arr[i] != 0)
            {
                for (int j = 0; j < arr[i]; j++)
                    sw.WriteLine(i);
            }
        }
    }
}