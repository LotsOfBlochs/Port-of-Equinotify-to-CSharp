using System;
using System.IO;

namespace Music_Player.mainPackage
{
    class MakeFile
    {
        public void dirGen()
        {
            try
            {
                string songsPath = Path.GetDirectoryName(Environment.GetEnvironmentVariable("AppData")+"\\Equinotify\\songs");
                string thumbnailPath = Path.GetDirectoryName(Environment.GetEnvironmentVariable("AppData") + "\\Equinotify\\thumbnails");

                Directory.CreateDirectory(songsPath);
                Directory.CreateDirectory(thumbnailPath);

                Console.WriteLine("Directory is created!");
            }catch (IOException e)
            {
                Console.WriteLine("Failed to create directory!" + e.Message);
            }
        }

        public void removeDir()
        {
            string song = Path.GetFullPath(Environment.GetEnvironmentVariable("AppData") + "\\Equinotify\\songs\\NA.wav");
            File.Delete(song);
            if (File.Exists(song))
            {
                Console.WriteLine("Deleted the file: " + song);
            }
            else
            {
                Console.WriteLine("Failed to delete the file.");
            }

            string tmp = Path.GetDirectoryName(Environment.GetEnvironmentVariable("AppData") + "\\Equinotify\\tmp");
            Directory.Delete(tmp);
            if (Directory.Exists(tmp))
            {
                Console.WriteLine("Deleted the folder: " + tmp);
            }
            else
            {
                Console.WriteLine("Failed to delete the folder.");
            }
        }
    }
}
