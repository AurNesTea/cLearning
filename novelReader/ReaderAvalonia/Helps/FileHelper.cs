using System;
using System.IO;
using System.Collections.Generic;

namespace ReaderAvalonia.Helps
{
    public static class FileHelper
    {
        public static IEnumerable<string> ReadLines(string path)
        {
            if (File.Exists(path))
                return File.ReadLines(path);
            else
                return Array.Empty<string>();
        }

        public static void SaveText(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
