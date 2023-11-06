using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Class1
    {
        public Class1 (int min, int max) 
        {
            int minStr = min;
            int maxStr = max;
        }
        public static int Strelki(int minStr, int maxStr)
        {
            int pos = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != minStr)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow && pos != maxStr)
                    pos++;
                if (key.Key == ConsoleKey.Escape)
                {
                    pos = 90;
                }
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);
            return pos;
        }
    }
}
