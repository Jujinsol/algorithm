using System;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        SortedSet<string> name = new SortedSet<string>();
        name.Add("ChongChong");
        int i, count = 0;
        string[] result;
        string s;

        for (i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            result = s.Split();

            if (name.Contains(result[0]) != name.Contains(result[1]) || name.Contains(result[1]) != name.Contains(result[0]))
            {
                name.Add(result[0]);
                name.Add(result[1]);
            }
        }
        Console.WriteLine(name.Count);
    }
}