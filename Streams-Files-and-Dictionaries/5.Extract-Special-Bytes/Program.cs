namespace ExtractBytes
{
    using System;
    using System.IO;
    using System.Linq;

    public class ExtractBytes
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"../../../Files/example.png";
            string bytesFilePath = @"../../../Files/bytes.txt";
            string outputPath = @"../../../Files/output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            string[] special = File.ReadAllLines(bytesFilePath);
            byte[] specialBytes = special.Select(s => byte.Parse(s)).ToArray();

            byte[] buff = File.ReadAllBytes(binaryFilePath);

            using (var writer = new FileStream(outputPath, FileMode.OpenOrCreate))
            {
                foreach (var item in buff)
                {
                    if (specialBytes.Contains(item))
                    {
                        writer.WriteByte(item);
                    }
                }
            }
        }
    }
}
