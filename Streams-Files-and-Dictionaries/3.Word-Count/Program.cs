namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var occurences = new Dictionary<string, int>();
            string[] words = File.ReadAllText(wordsFilePath)
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            occurences = words.ToDictionary(key => key, Value => 0);

            string[] lines = File.ReadAllLines(textFilePath).Select(line => line.ToLower()).ToArray();

            foreach (var line in lines)
            {
                foreach (var word in words)
                {
                    var matchesCount = Regex.Matches(line, $@"\W{word}\W").Count;
                    occurences[word] += matchesCount;
                }
            }

            occurences = occurences.OrderByDescending(o => o.Value)
                .ToDictionary(w => w.Key, o => o.Value);

            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var (w, times) in occurences)
                {
                    writer.WriteLine($"{w} - {times}");
                }
            }
        }
    }
}