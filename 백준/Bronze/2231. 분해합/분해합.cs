using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        int N = int.Parse(sr.ReadLine());
        int[] eachNum = new int[(int)Math.Log10(N) + 1];
        int maker = 0;
        int sum = 0;

        for (int i = 0; i < N; i ++)
        {
            sum = 0;
            eachNum = new int[Convert.ToString(i).Length];
            for (int j = 0; j < eachNum.Length; j++)
            {
                eachNum[j] = int.Parse(Convert.ToString(i).Substring(j, 1));
                sum += eachNum[j];
            }
            if (i == N - sum)
            {
                maker = i;
                break;
            }
        }

        Console.WriteLine(maker);
    }
}