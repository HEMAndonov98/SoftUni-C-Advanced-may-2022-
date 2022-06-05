namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"../../../Files/example.png";
            string joinedFilePath = @"../../../Files/example-joined.png";
            string partOnePath = @"../../../Files/part-1.bin";
            string partTwoPath = @"../../../Files/part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] buffer = File.ReadAllBytes(sourceFilePath);
            int bufferSplit = buffer.Length / 2;

            using (var writer1 = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
            {
                writer1.Write(buffer, 0, bufferSplit + 1);
            }

            using (var writer2 = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
            {
                writer2.Write(buffer, 0, bufferSplit);
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var reader1 = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
            {
                
                byte[] buffer1 = new byte[reader1.Length];
              
                using (var writer1 = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
                {
                    if (writer1.CanWrite)
                        writer1.Write(buffer1, 0, buffer1.Length);
                }
            }

            using (var reader2 = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer2 = new byte[reader2.Length];

                using (var writer2 = new FileStream(joinedFilePath, FileMode.Append, FileAccess.Write))
                {
                    if(writer2.CanWrite)
                    writer2.Write(buffer2, 0 , buffer2.Length);
                }
            }
        }
    }
}