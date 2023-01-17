using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int[,] arr1 = new int[N, M], arr2 = new int[N, M], arr3 = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            for (int j = 0; j < M; j++)
                arr1[i, j] = int.Parse(s1[j]);
        }

        for (int i = 0; i < N; i++)
        {
            string[] s2 = Console.ReadLine().Split();
            for (int j = 0; j < M; j++)
                arr2[i, j] = int.Parse(s2[j]);
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                arr3[i,j] = arr1[i, j] + arr2[i, j];
                Console.Write(arr3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}