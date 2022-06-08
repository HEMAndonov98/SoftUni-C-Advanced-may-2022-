namespace ZipAndExtract
{
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
            using (var source = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                if (File.Exists(zipArchiveFilePath))
                    File.Delete(zipArchiveFilePath);

                using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(source.Name, Path.GetFileName(source.Name));
                }
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {          
            using (var archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                foreach (var entry in archive.Entries)
                {
                    entry.ExtractToFile(outputFilePath);
                }
            }
        }
    }
}
