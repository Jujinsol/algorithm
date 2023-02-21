using System;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int N = int.Parse(sr.ReadLine());
        int M = N / 4;

        for (int i = 0; i < M; i++)
        {
            sw.Write("long ");
        }
        sw.Write("int");
    }
}