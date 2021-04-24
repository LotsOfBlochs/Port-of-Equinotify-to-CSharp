using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Net;
using System;

namespace Music_Player.mainPackage
{
    class Downloader
    {
        public async void download_song()
        {
            if (Constants.title.Contains("\\") || Constants.title.Contains("|"))
            {
                Constants.title = Constants.title.Replace("\\", " ");
                Constants.title = Constants.title.Replace("|", " ");
            }
            var youtube = new YoutubeClient();
            await youtube.Videos.DownloadAsync(Constants.url + Constants.id, Constants.songDownloadPath + "\\" + Constants.title + ".wav");
        }
        public void download_thumbnail()
        {
            if (Constants.title.Contains("\\") || Constants.title.Contains("|"))
            {
                Constants.title = Constants.title.Replace("\\", " ");
                Constants.title = Constants.title.Replace("|", " ");
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://img.youtube.com/vi/" + Constants.id + "/0.jpg", Constants.thumbnailDownloadPath + "\\" + Constants.title + ".jpg");
            }
        }
    }
}
