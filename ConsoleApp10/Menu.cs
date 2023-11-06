using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Menu
    {
        public static void ShowPapkas(string s)
        {
            while (true)
            {
                Console.Clear();
                string[] pathss = Directory.GetDirectories(s);
                string[] files = Directory.GetFiles(s);
                var paths = pathss.Concat(files).ToArray();
                foreach (string path in paths)
                {
                    FileInfo fileInfo = new FileInfo(path);
                    Console.WriteLine("  " + path + "                    " + fileInfo.CreationTime + "                    " + fileInfo.Extension);
                }
                int pos = Class1.Strelki(0, paths.Length - 1);
                if (pos == 90)
                {
                    return;
                }
                string extension = Path.GetExtension(paths[pos]);
                if (extension != "")
                {
                    Process.Start(new ProcessStartInfo {FileName = paths[pos], UseShellExecute = true });
                }
                else
                {
                    ShowPapkas(paths[pos]);
                }
            }
        }
    }
}
