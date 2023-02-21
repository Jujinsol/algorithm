using System;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] s = sr.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = i + 1;
        }

        string[] s2;
        int A, B;

        for (int i = 0; i < M; i++)
        {
            s2 = sr.ReadLine().Split();
            A = int.Parse(s2[0]);
            B = int.Parse(s2[1]);

            Array.Reverse(arr, A - 1, B - A + 1);
        }

        for (int i = 0; i < N; i++)
            sw.Write(arr[i] + " ");
    }
}