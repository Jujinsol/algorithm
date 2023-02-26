using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Transactions;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] count = new int[100000];
        int N = int.Parse(sr.ReadLine());
        int last = -1;
        int num;
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            num = int.Parse(sr.ReadLine());
            if (num != 0)
            {
                last++;
                count[last] = num;
                sum += num;
            }
            else
            {
                sum -= count[last];
                count[last] = 0;
                last--;
            }
        }
        sw.Write(sum);
    }
}