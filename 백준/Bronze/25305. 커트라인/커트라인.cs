using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int k = int.Parse(s[1]);
        string[] scores = Console.ReadLine().Split();
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
            arr[i] = int.Parse(scores[i]);

        for (int i = 0; i < N; i++)
        {
            if (i == N - 1)
                break;
            for (int j = i + 1; j < N; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine(arr[k-1]);
    }
}