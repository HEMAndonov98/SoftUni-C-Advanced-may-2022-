namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (var textReader = new StreamReader(inputFilePath))
            {
                string line;
                int count = 1;
                using (var textWriter = new StreamWriter(outputFilePath))
                {
                    while ((line = textReader.ReadLine()) != null)
                    {
                        textWriter.WriteLine($"{count}. {line}");
                    }
                    
                }
            }
        }
    }
}
