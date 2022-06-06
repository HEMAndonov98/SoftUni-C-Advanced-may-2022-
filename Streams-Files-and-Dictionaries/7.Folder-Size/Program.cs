namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"../../../Files/TestFolder";
            string outputPath = @"../../../Files/output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = dirInfo.GetFiles("*", SearchOption.AllDirectories);
            double fileSize = 0;

            foreach (var file in files)
            {
                fileSize += file.Length;
            }

            fileSize /= 1024;

            File.WriteAllText(outputFilePath, fileSize.ToString());
        }
    }
}
