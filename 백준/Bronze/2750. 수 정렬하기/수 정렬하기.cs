using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] num = new int[N];

        for (int i = 0; i < N; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            if (i == N - 1)
                break;
            for (int j = i + 1; j < N; j++)
            {
                if (num[i] > num[j])
                {
                    int temp = num[i];
                    num[i] = num[j];
                    num[j] = temp;
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
}