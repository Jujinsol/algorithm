using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        string[] s = sr.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        Dictionary<string, int> dic = new Dictionary<string, int>();
        Dictionary<int, string> dic2 = new Dictionary<int, string>();

        for (int i = 0; i < N; i++)
        {
            string monster = sr.ReadLine();
            dic.Add(monster, i + 1);
            dic2.Add(i + 1, monster);
        }

        for (int i = 0; i < M; i++)
        {
            string a = sr.ReadLine();
            if (dic.ContainsKey(a))
                sb.Append(dic[a] + "\n");
            else
                sb.Append(dic2[int.Parse(a)] + "\n");
        }
        sw.WriteLine(sb.ToString());
    }
}