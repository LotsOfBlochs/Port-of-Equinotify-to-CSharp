using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Net;

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
                //try
                //{
                webClient.DownloadFile("https://i.ytimg.com/vi/" + Constants.id + "/hq720.jpg", Constants.thumbnailDownloadPath + "\\" + Constants.title + ".jpg");
                //}
                //catch {  }
            }
        }
    }
}
