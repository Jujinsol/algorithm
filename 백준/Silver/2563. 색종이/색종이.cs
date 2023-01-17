using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int max = 10 * 10 * N;
        bool[,] arr = new bool[100, 100];
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            for (int j = a; j < a + 10; j++)
            {
                for (int k = b; k < b + 10; k ++)
                {
                    arr[j, k] = true;
                }
            }
        }

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
                if (!arr[i, j])
                    count++;
        }
        Console.WriteLine(10000 - count);
    }
}