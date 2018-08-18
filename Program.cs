using System;
using System.IO;
using System.Text;

namespace FileLineSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int linenumber = 0;
            if (args.Length == 2) 
            {
                if (File.Exists(args[0])) 
                {
                    foreach (string line in File.ReadLines(args[0], Encoding.UTF8))
                    {
                        // process the line
                        linenumber++;
                        if (line.IndexOf(args[1], StringComparison.CurrentCultureIgnoreCase) >= 0) {
                            Console.WriteLine(linenumber.ToString() + ": " + line);
                        }
                    }
                }
                else 
                {
                    System.Console.WriteLine("Invalid Filename argument.");
                    System.Console.WriteLine("Usage: FileLineSearch.exe InputFilename SearchText");
                    return;
                }
            } 
            else 
            {
                System.Console.WriteLine("Incorrect number of parameters.");
                System.Console.WriteLine("Usage: FileLineSearch.exe InputFilename SearchText");
                return;
            }

        }
    }
}
