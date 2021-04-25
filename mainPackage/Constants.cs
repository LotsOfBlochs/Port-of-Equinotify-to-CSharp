using System;
using System.Collections.Generic;

namespace Music_Player.mainPackage
{
    class Constants
    {
        public static string songDownloadPath = Environment.GetEnvironmentVariable("AppData") + "\\Equinotify\\songs";
        public static string thumbnailDownloadPath = Environment.GetEnvironmentVariable("AppData") + "\\Equinotify\\thumbnails";
        public static string url = "https://www.youtube.com/watch?v=";
        public static string id = "";
        public static string scraperURL = "https://www.youtube.com/results?search_query=";
        public static string title = "";

        public static List<string> playlistSongTitles = new List<string>();
        public static List<string> playlistSongPaths = new List<string>();

        public static int windowWidth = 1000;
        public static int windowHeight = 850;
    }
}
