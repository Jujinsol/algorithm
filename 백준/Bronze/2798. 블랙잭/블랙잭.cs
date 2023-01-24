using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int[] num = new int[N];
        string[] numbers = Console.ReadLine().Split();

        for(int i = 0; i < N; i ++)
            num[i] = int.Parse(numbers[i]);
        int sum = 0;

        Array.Sort(num);

        for (int i = 0; i < num.Length - 2; i ++)
        {
            bool Flag = false;
            for (int j = i + 1; j < num.Length - 1; j++)
            {
                for (int k = j + 1; k < num.Length; k ++)
                {
                    int temp = num[i] + num[j] + num[k];
                    if (temp == M)
                    {
                        sum = temp;
                        Flag = true;
                    }
                    if (temp > M)
                        continue;
                    if (M - temp < M - sum)
                        sum = temp;
                }
                if (Flag)
                    break;
            }
            if (Flag)
                break;
        }

        Console.WriteLine(sum);
    }
}