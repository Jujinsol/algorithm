using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] arr = new bool[2 * N + 1];
            int count = 0;

            if (N == 0)
                break;

            for (int i = 2; i <= 2 * N; i++)
                arr[i] = true;

            for (int i = 2; i <= 2 * N; i++)
            {
                if (arr[i])
                {
                    for (int j = i * 2; j <= 2 * N; j += i)
                        arr[j] = false;
                }
            }
            for (int i = N + 1; i <= 2 * N; i++)
                if (arr[i])
                    count++;
            Console.WriteLine(count);
        }
    }
}