using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int min = 0; int sum = 0;
        bool[] arr = new bool[N + 1];
        bool ok = false;

        for (int i = M; i <= N; i ++)
        {
            for (int j = 2; j < i; j++)
            {
                ok = false;
                if (i % j == 0)
                    break;
                else
                    ok = true;
            }
            if (ok | i == 2)
                arr[i] = true;
        }

        for (int i = M; i <= N; i ++)
        {
            if (arr[i])
            {
                sum += i;
                if (min == 0)
                    min = i;
            }
        }

        if (sum == 0)
            Console.WriteLine(-1);
        else
        {
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
    }
}