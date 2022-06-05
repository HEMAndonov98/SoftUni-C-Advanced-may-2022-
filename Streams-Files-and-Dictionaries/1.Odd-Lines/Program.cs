namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                int count = 0;
                string line;
                using (var writer = new StreamWriter(outputFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (count % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                    }
                }
            }
        }
    }
}
