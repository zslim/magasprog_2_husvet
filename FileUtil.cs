using System;
using System.Collections.Generic;
using System.IO;

namespace Husvet
{
    class FileUtil
    {
        public static List<string[]> ReadFile(string path)
        {
            List<string[]> fileContent = new List<string[]>();

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    fileContent.Add(line.Split(","));
                }
            }
            return fileContent;
        }
    }
}