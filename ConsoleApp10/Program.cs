namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                Console.Clear();
                for (int i = 0; i < drives.Length; i++)
                {
                    Console.WriteLine($"  {drives[i].Name}                   {drives[i].TotalSize / (1024 * 1024 * 1024) - drives[i].AvailableFreeSpace / (1024 * 1024 * 1024)} ГБ занято из {drives[i].TotalSize / (1024 * 1024 * 1024)} ГБ");
                }
                int pos = Class1.Strelki(0, drives.Length - 1);
                string s = drives[pos].Name;
                Menu.ShowPapkas(s);
            } while (true);
        }
    }
}