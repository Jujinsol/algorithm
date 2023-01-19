using System;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int N = int.Parse(sr.ReadLine());
        List<string> list = new List<string>();

        for (int i = 0; i < N; i++)
        {
            string s = sr.ReadLine();
            list.Add(s);
        }

        list = list.Distinct().ToList();
        list.Sort();
        list = list.OrderBy(x => x.Length).ToList();

        foreach (string word in list)
            Console.WriteLine(word);
    }
}