using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(sr.ReadLine());
        }

        Array.Sort(arr);
        int[] count = arr.Distinct().ToArray();
        int[] count2 = arr.Distinct().ToArray();

        for (int i = 1; i < N; i++)
        {
            if (arr[i] == arr[i - 1])
                count[Array.IndexOf(count2, arr[i])]++;
        }

        int max = 0;
        for (int i = 1; i < count.Length; i++)
        {
            if (count[i] - count2[i] > count[max] - count2[max])
                max = i;
        }

        int a = 0;
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] - count2[i] == count[max] - count2[max])
            {
                max = i;
                if (a == 1)
                    break;
                a++;
            }
        }

        sw.WriteLine((Math.Round((double)arr.Sum() / N)) == -0 ? 0 : Math.Round((double)arr.Sum() / N));
        sw.WriteLine(arr[(N - 1) / 2]);
        sw.WriteLine(count2[max]);
        sw.WriteLine(arr[N - 1] - arr[0]);
    }
}