using Music_Player.mainPackage;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System;
using System.Threading.Tasks;

namespace Music_Player.userInterface
{
    class SearchBox
    {
        bool Done = false;
        public static Button enterSearch = new();
        public static TextBox searchBox = new();
        WebScraper scraper = new();
        Downloader d = new();
        public static Player player = new();
        //Pause pause = new();
        bool firstSong = true;

        public void addSearch()
        {
            enterSearch.SetBounds(5, Constants.windowWidth-85, 80, 25);
            enterSearch.Text = "Submit";
            enterSearch.BackColor = Color.Black;
            enterSearch.UseVisualStyleBackColor = true;
            enterSearch.Click += EnterSearch;
            enterSearch.Enter += EnterSearch;
            searchBox.SetBounds(5, 5, Constants.windowWidth - 100 - 25, 25);
            //searchBox.Enter += EnterSearch;
            TopPanel.topPanel.Controls.Add(enterSearch);
            TopPanel.topPanel.Controls.Add(searchBox);
        }

        private void EnterSearch(object sender, System.EventArgs e)
        {
            Constants.title = "";
            if(sender == enterSearch || sender == searchBox)
            {
                if (!firstSong)
                {
                    player.player.close();
                }firstSong = false;

                Done = false;
                isUrl();
                while (!Done) { Task.Delay(new TimeSpan(0, 0, 1)); }

                string checkTitle = Constants.title;

                if(checkTitle.Contains("\\") || checkTitle.Contains("|"))
                {
                    checkTitle = checkTitle.Replace("\\", " ");
                    checkTitle = checkTitle.Replace("|", " ");
                }

                string song = Path.GetFullPath(Constants.songDownloadPath + "\\" + checkTitle + ".wav");

                if (File.Exists(song))
                {
                    SongName.songInfo.Text = Constants.title;
                    //currentThumbnail.setImage;
                    //thumbnailLabel
                    Constants.scraperURL = "https://www.youtube.com/results?search_query=";
                    Constants.id = "";

                    player.Music();
                }
                else
                {
                    Constants.scraperURL = "https://www.youtube.com/results?search_query=";
                    d.download_song();
                    d.download_thumbnail();
                    SongName.songInfo.Text = Constants.title;

                    player.Music();

                    Pause.isPaused = false;
                }
            }
        }

        public async void isUrl()
        {
            if (searchBox.Text.Contains("https"))
            {
                Constants.url = searchBox.Text;
            }else
            {
                Constants.scraperURL = Constants.scraperURL + searchBox.Text.ToLower().Replace(" ", "+");
                Constants.id = await scraper.FindIDAsync();
                Constants.id = await scraper.FindSongName();
                Done = true;
            }
        } 
    }
}
