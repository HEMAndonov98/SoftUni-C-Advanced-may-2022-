using System;
using System.Linq;
using System.Text;

namespace _1.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = null;

            string lines;
            while ((lines = Console.ReadLine()) != "END")
            {
                if (lines.StartsWith("Create"))
                {
                         iterator = new ListyIterator<string>(lines.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToArray());
                }
                else if (lines == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (lines == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (lines == "Print")
                {
                    iterator.Print();
                }
                else if (lines == "PrintAll")
                {
                    var sb = new StringBuilder();

                    foreach (var item in iterator)
                    {
                        sb.Append($"{item} ");
                    }

                    Console.WriteLine(sb.ToString().Trim());
                }
            }
        }
    }
}

