using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        BigInteger a = BigInteger.Parse(s[0]);
        BigInteger b = BigInteger.Parse(s[1]);
        Console.WriteLine(a + b);
    }
}