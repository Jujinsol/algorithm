using System;
using System.Data;
using System.Text;

class Program
{
    static int unique(int[] arr, int n)
    {
        int i = 0, j = 0;
        for (i = 1; i < n; i++)
        {
            if (arr[i] == arr[j])
                continue;
            arr[++j] = arr[i];
        }
        return ++j;
    }

    static int binarysearch(int[] arr, int size, int key)
    {
        int left = 0, right = size - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] < key)
                left = mid + 1;
            else if (arr[mid] > key)
                right = mid - 1;
            else
                return mid;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        int[] arr = new int[N];
        int[] sort = new int[N];
        string[] s = sr.ReadLine().Split();

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(s[i]);
            sort[i] = arr[i];
        }

        Array.Sort(sort);

        int num = unique(sort, N);

        for (int i = 0; i < N; i++)
        {
            int point = binarysearch(sort, num, arr[i]);
            sw.Write(point + " ");
        }
    }
}