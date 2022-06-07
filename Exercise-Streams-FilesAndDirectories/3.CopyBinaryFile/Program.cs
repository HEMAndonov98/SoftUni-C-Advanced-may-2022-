namespace CopyBinaryFile
{
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"../../../copyMe.png";
            string outputFilePath = @"../../../copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var reader = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var writer = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buff = new byte[1024];
                    while ((reader.Read(buff, 0, buff.Length) > 0))
                    {
                        writer.Write(buff, 0, buff.Length);
                    }
                }
            }
        }
    }
}
