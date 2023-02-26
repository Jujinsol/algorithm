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

        string question;
        int N = int.Parse(sr.ReadLine());

        for (int i = 0; i < N; i++)
        {
            question = sr.ReadLine();
            while (question.Contains("()"))
            {
                if (question.Contains("()"))
                {
                    question = question.Replace("()", "");
                }
            }
            if (question.Length == 0)
                sw.WriteLine("YES");
            else
                sw.WriteLine("NO");
        }
    }
}