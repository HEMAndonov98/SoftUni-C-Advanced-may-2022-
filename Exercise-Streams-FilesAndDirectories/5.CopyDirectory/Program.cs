namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            //this is the information of the dir we're going to copy
            var dir = new DirectoryInfo(inputPath);
            if(!dir.Exists)
                Console.WriteLine("Directory doesn't exist");

            //this is an array containing all the files inside the directory
            var files = dir.GetFiles();

            string targetDirectoryPath = Path.Combine(outputPath, dir.Name);

            //if directory exists delete it so we don't get an exeption
            if (Directory.Exists($"{targetDirectoryPath}-copy"))
                Directory.Delete($"{targetDirectoryPath}-copy", true);
            //We create a dir with the same name as the original dir but we add a "-copy" at the end
            Directory.CreateDirectory($"{targetDirectoryPath}-copy");

            foreach (var file in files)
            {
                //each file is given a new path consisting of the new directory path and the files original name
                string targetFilePath = Path.Combine($"{targetDirectoryPath}-copy", file.Name);
                file.CopyTo(targetFilePath);
            }
        }
    }
}
