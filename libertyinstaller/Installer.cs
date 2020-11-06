using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace libertyinstaller
{
    class Installer
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Liberty City Minimap Tool";
            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/../Local/FiveM/FiveM.app/citizen/platform/data/tune/minimap.ymt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Uninstalled the liberty city map addon! Press ENTER to close the window.");
                Console.ReadLine();
                return;
            }
            var uri = "http://outlawliferp.us/liberty/minimap.ymt";
            using (WebClient client = new WebClient())
            {
                var ur = new Uri(uri);
                client.DownloadFileAsync(ur, filePath);
                Console.WriteLine("Downloaded the liberty city map addon! Press ENTER to the close window.");
                Console.ReadLine();
            }
        }
    }
}
