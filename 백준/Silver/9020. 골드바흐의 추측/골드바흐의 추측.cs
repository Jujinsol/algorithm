using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int a = 0, b = 0, c = 0;
        int tempA = 0, tempB = 0;

        for (int i = 0; i < T; i++)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] arr = new bool[N + 1];

            for (int j = 2; j <= N; j++)
                arr[j] = true;

            for (int j = 2; j <= N; j++)
            {
                if (arr[j])
                {
                    for (int k = j * 2; k <= N; k += j)
                        arr[k] = false;
                }
            }

            for (int q = 2; q <= N; q++)
            {
                a = q; b = N - a;
                if (arr[q] && arr[b])
                {
                    c = b - a;
                    if (c == 0)
                        break;
                    if (c < 0)
                    {
                        a = tempA;
                        b = tempB;
                        break;
                    }
                    tempA = a;
                    tempB = b;
                }
            }

            Console.WriteLine(a + " " + b);
        }        
    }
}