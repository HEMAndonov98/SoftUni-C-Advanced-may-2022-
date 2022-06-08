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
            using (var source = new FileStream(inputFilePath, FileMode.Open, FileAccess.ReadWrite))
            {
                using (var archive = new ZipArchive(source, ZipArchiveMode.Create))
                {
                    archive.CreateEntry(source.Name);
                }
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
