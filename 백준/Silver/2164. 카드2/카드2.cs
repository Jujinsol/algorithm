using System;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());        
        Queue<int> queue = new Queue<int>();

        int N = int.Parse(sr.ReadLine());
        int a;

        for (int i = 0; i < N; i++)
        {
            queue.Enqueue(i + 1);
        }

        while (queue.Count != 1)
        {
            queue.Dequeue();
            a = queue.Dequeue();
            queue.Enqueue(a);
        }

        sw.WriteLine(queue.Peek());
    }
}