using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] weight = new int[N];
        int[] height = new int[N];
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            weight[i] = int.Parse(s[0]);
            height[i] = int.Parse(s[1]);
        }

        for (int i = 0; i <N; i++)
        {
            count = 0;
            for (int j = 0; j < N; j++)
            {
                if (height[i] < height[j] && weight[i] < weight[j])
                    count++;
            }
            Console.WriteLine(count + 1);
        }
    }
}