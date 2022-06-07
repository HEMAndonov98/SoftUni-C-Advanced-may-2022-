namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"../../../text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            List<string> lines = new List<string>();
            using (var reader = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            lines = lines.Where((l, i) => i % 2 == 0).Select(l => ReplaceSymbol(l)).ToList();
            lines = ReverseWordsInList(lines);
            return string.Join(Environment.NewLine, lines);
        }

        public static string ReplaceSymbol(string line)
        {
            return line.Replace('-', '@')
                .Replace(',', '@')
                .Replace('.', '@')
                .Replace('!', '@')
                .Replace('?', '@');
        }
        public static List<string> ReverseWordsInList(List<string> lines)
        {
            List<string> reversedWords = new List<string>();
            foreach (var line in lines)
            {
                string[] temp = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Reverse()
                    .ToArray();
                reversedWords.Add(string.Join(' ', temp));
            }

            return reversedWords;
        }
    }
}
