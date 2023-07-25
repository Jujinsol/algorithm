using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int i, num = 0;
        string enter = null;
        SortedSet<string> s = new SortedSet<string>();
        enter = Console.ReadLine();

        for (i = 0; i < n-1; i++)
        {
            enter = Console.ReadLine();

            if (enter == "ENTER")
            {
                num += s.Count();
                s.Clear();
            }
            else
            {
                s.Add(enter);
            }
        }
        num += s.Count();
        Console.WriteLine(num);
    }
}