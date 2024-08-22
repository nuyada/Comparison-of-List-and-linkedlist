using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections;
using System.Diagnostics;
using System.Text;


namespace CountWords
{
    class Program
    {
        //  Объявим словарь с двумя значениями


        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\DALBI\\Desktop\\Text1.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            List<string> words = new List<string>(text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries));
            var stopWatch = Stopwatch.StartNew();
            List<string> list = new List<string>();
            foreach (var word in words)
            {
                list.Add(word);
            }
            stopWatch.Stop();
            Console.WriteLine($"Время вставки в List<t> {stopWatch.Elapsed.TotalMilliseconds}");
            stopWatch.Restart();
            LinkedList<string> linkedlist = new LinkedList<string>();
            foreach (var word in words)
            {
                linkedlist.AddLast(word);
            }
            stopWatch.Stop();
            Console.WriteLine($"Время вставки в LinkedList<t> {stopWatch.Elapsed.TotalMilliseconds}");
        }

    }
}