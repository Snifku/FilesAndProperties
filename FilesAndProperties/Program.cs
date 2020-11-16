using System;
using System.Collections.Generic;
using System.IO;


namespace FilesAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //To get the files names only
            string rootPath = @"C:\Users\opilane\samples";
            string txt = @"C:\Users\opilane\samples\filedata.txt";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach(string file in files)
            {
                
                //get file objects


                var fileData = new FileInfo(file);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                //Console.WriteLine($"File name: {fileName}; location: {fileDirectory}; Size: {fileSize} ");
                string line = $"File name: {fileName}; location: {fileDirectory}; Size: {fileSize} bytes";
                lines.Add(line);
                File.WriteAllLines(txt, lines);
            }

            string fileDataPath = @"C:\Users\opilane\samples\fileData.txt";
            Console.WriteLine("written!");
        }
    }
}
