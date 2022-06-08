namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"../../../copyMe.png";
            string zipArchiveFile = @"../../../archive.zip";
            string extractedFile = @"../../../extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            using (var source = new FileStream(inputFilePath, FileMode.Open, FileAccess.ReadWrite))
            {
                using (var archive = new ZipArchive(source, ZipArchiveMode.Create))
                {
                    archive.CreateEntry(source.Name);
=======
=======
>>>>>>> Stashed changes
            using (var source = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                if (File.Exists(zipArchiveFilePath))
                    File.Delete(zipArchiveFilePath);

                using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(source.Name, Path.GetFileName(source.Name));
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                }
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        {
            throw new NotImplementedException();
=======
=======
>>>>>>> Stashed changes
        {           
                using (var archive = ZipFile.OpenRead(zipArchiveFilePath))
                {
                    foreach (var entry in archive.Entries)
                    {
                        entry.ExtractToFile(outputFilePath);
                    }
                }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }
    }
}
