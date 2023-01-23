using System;
using System.Text;

class Program
{
    static bool Empty(int x, int y)
    {
        while (x != 0)
        {
            if (x % 3 == 1 && y % 3 == 1)
                return true;
            x /= 3;
            y /= 3;
        }
        return false;
    }

    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(sr.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (Empty(i, j))
                {
                    sb.Append(" ");
                    continue;
                }
                sb.Append("*");
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}