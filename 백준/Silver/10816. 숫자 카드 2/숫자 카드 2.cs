using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        sr.ReadLine();
        Dictionary<int, int> dic = new Dictionary<int, int>();

        sr.ReadLine().Split().Select(int.Parse).ToList().ForEach(x =>
        {
            if (dic.ContainsKey(x))
                dic[x]++;
            else
                dic.Add(x, 1);
        });
        sr.ReadLine();
        sr.ReadLine().Split().Select(int.Parse).ToList().ForEach(x =>
        {
            if (dic.ContainsKey(x))
                sw.Write($"{dic[x]} ");
            else
                sw.Write("0 ");
        });
    }
}