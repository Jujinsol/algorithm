using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] num = new int[N];

        for (int i = 0; i < N; i++)
            num[i] = int.Parse(Console.ReadLine());

        Array.Sort(num);
        StringBuilder sb = new StringBuilder(string.Join("\n", num));

        Console.WriteLine(sb);
    }
}