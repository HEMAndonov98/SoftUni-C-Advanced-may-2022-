namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] input1 = File.ReadAllLines(firstInputFilePath);
            string[] input2 = File.ReadAllLines(secondInputFilePath);

            using (var writer = new StreamWriter(outputFilePath))
            {
                int minLines = Math.Min(input1.Length, input2.Length);

                for (int i = 0; i < minLines; i++)
                {
                    writer.WriteLine(input1[i]);
                    writer.WriteLine(input2[i]);
                }

                if (input1.Length > input2.Length)
                {
                    for (int j = minLines - 1; j < input1.Length; j++)
                    {
                        writer.WriteLine(input1[j]);
                    }
                }
                else if (input2.Length > input1.Length)
                {
                    for (int k = minLines - 1; k < input2.Length; k++)
                    {
                        writer.WriteLine(input2[k]);
                    }
                }
            }
        }
    }
}
