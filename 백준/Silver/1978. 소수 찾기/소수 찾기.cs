using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] num = Console.ReadLine().Split();
        int sosoo = N;

        for (int i = 0; i < N; i++)
        {
            bool ok = true;
            if (int.Parse(num[i]) == 1)
                ok = false;

            for (int j = 2; j < int.Parse(num[i]); j++)
            {
                if (int.Parse(num[i]) % j == 0)
                    ok = false;                
            }
            if (!ok)
                sosoo--;
        }
        Console.WriteLine(sosoo);
    }
}