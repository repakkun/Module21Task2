using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Module21Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("/Users/1/Downloads/Text1.txt");
            var clearText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            var list = new List<string>();
            var countList = new List<int>(); var wordList = new List<string>();

            list.Add(clearText);
            var words = clearText.Split(" ");

            foreach (var w in words)
            {
                countList.Add(w.Count());
                wordList.Add(w);
            }
            countList.Sort();
            Console.WriteLine("Количество самых частых слов: ");
            for (int i = countList.Count - 10; i < countList.Count; i++)
            {
                Console.WriteLine(countList[i]);
            }

        }
    }
}