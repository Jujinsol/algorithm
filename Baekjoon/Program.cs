using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        /* 1. N이 5의 배수
         * 2. N이 3의 배수
         * 3. N을 5로 나눴는데 나머지가 3의 배수
         * 4. N을 3으로 나눴는데 나머지가 5의 배수 
         */

        int N = int.Parse(Console.ReadLine());
        int count = 0;

        while (N > 0)
        {
            if (N % 5 == 0)
            {
                N -= 5;
                count++;
            }
            else if (N % 3 == 0)
            {
                N -= 3;
                count++;
            }
            else if (N > 5)
            {
                N -= 5;
                count++;
            }
            else
            {
                count = -1;
                break;
            }
        }
        Console.WriteLine(count);
    }
}