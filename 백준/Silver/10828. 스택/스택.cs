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

        int N = int.Parse(sr.ReadLine());
        int[] stack = new int[100000];
        int last = -1;
        string funcName;

        string[] s;
        for (int i = 0; i < N; i++)
        {
            s = sr.ReadLine().Split();
            funcName = s[0];
            switch (funcName)
            {
                case "push":
                    last++;
                    stack[last] = int.Parse(s[1]);
                    break;
                case "pop":
                    if (last == -1)
                        sw.WriteLine("-1");
                    else
                    {
                        sw.WriteLine($"{stack[last]}");
                        stack[last] = 0;
                        last--;
                    }
                    break;
                case "size":
                    sw.WriteLine($"{last + 1}");
                    break;
                case "empty":
                    if (last == -1)
                        sw.WriteLine("1");
                    else
                        sw.WriteLine("0");
                    break;
                case "top":
                    if (last == -1)
                        sw.WriteLine("-1");
                    else
                        sw.WriteLine($"{stack[last]}");
                    break;
            }
        }
    }
}