using System;
using System.Text;

class Program
{
    static bool BinarySearch(int[] arr, int target, int low, int high)
    {
        if (low > high)
            return false;
        int mid = (low + high) / 2;
        if (arr[mid] == target)
            return true;
        else if (arr[mid] > target)
            return BinarySearch(arr, target, low, mid - 1);
        else
            return BinarySearch(arr, target, mid + 1, high);
    }

    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(sr.ReadLine());
        int[] have = new int[N];
        string[] s = sr.ReadLine().Split();

        for (int i = 0; i < N; i++)
            have[i] = int.Parse(s[i]);
        Array.Sort(have);

        int M = int.Parse(sr.ReadLine());
        int[] question = new int[M];
        string[] ss = sr.ReadLine().Split();

        for (int i = 0; i < M; i++)
            question[i] = int.Parse(ss[i]);

        foreach (int i in question)
        {
            if (BinarySearch(have, i, 0, N - 1))
                sb.Append(1 + " ");
            else
                sb.Append(0 + " ");
        }
        sw.WriteLine(sb.ToString());
    }
}