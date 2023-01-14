using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int num = M;

        while (num > 2)
        {
            for (int i = 2; i <= M; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                    break;
                }
            }
        }
        if ( num == 2)
            Console.WriteLine(2);
    }
}