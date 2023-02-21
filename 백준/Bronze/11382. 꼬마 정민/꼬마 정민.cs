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
        StringBuilder sb = new StringBuilder();

        string[] s = sr.ReadLine().Split(); 
        BigInteger a = BigInteger.Parse(s[0]);
        BigInteger b = BigInteger.Parse(s[1]);
        BigInteger c = BigInteger.Parse(s[2]);

        sw.WriteLine(a + b + c);
    }
}