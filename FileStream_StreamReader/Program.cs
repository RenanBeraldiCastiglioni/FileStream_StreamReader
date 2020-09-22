using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Windows\Temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
