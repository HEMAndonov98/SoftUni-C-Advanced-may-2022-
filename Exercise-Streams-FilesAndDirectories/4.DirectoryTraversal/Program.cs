namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var dirContent = new Dictionary<string, List<FileInDir>>();
            DirectoryInfo dir = new DirectoryInfo(inputFolderPath);
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                string extension = file.Extension;
                if (!dirContent.ContainsKey(extension))
                    dirContent[extension] = new List<FileInDir>();

                var newFile = new FileInDir(file.Name, file.Length);
                dirContent[extension].Add(newFile);
            }

            dirContent = dirContent.OrderByDescending(d => d.Value.Count)
                .ThenBy(d => d.Key)
                .ToDictionary(e => e.Key, f => f.Value);

            StringBuilder sb = new StringBuilder();
            foreach (var entry in dirContent)
            {
                sb.AppendLine(entry.Key);
                var sortedFiles = new List<FileInDir>(entry.Value.OrderBy(f => f.FileSize));
                foreach (var file in sortedFiles)
                {
                    sb.AppendLine($"--{file.FileName} ");
                }
            }
            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string deskPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/report.txt";
            File.WriteAllText(deskPath, textContent);
        }
    }

    public class FileInDir
    {
        public FileInDir(string name, long size)
        {
            this.FileName = name;
            this.FileSize = size;
        }

        public string FileName { get; set; }
        public long FileSize { get; set; }
    }
}

