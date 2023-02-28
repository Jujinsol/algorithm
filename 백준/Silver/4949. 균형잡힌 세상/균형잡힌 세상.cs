using System;
using System.Data;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string sentence;

        while (true)
        {
            sentence = sr.ReadLine();
            if (sentence == ".")
                break;

            StringBuilder sb = new StringBuilder();
            string somethingNew;
            int[] arr = new int[300];

            for (int i= 0; i < sentence.Length; i++)
            {
                arr[i] = (int)sentence[i];
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                if (arr[i] == 40 || arr[i] == 41 || arr[i] == 91 || arr[i] == 93)
                {
                    sb.Append(Convert.ToChar(arr[i]));
                }
            }

            somethingNew = sb.ToString();

            while (somethingNew.Contains("()") || somethingNew.Contains("[]"))
            {
                if (somethingNew.Contains("()"))
                {
                    somethingNew = somethingNew.Replace("()", "");
                }
                if (somethingNew.Contains("[]"))
                {
                    somethingNew = somethingNew.Replace("[]", "");
                }
            }

            if (somethingNew.Length == 0)
                sw.WriteLine("yes");
            else
                sw.WriteLine("no");
        }
    }
}