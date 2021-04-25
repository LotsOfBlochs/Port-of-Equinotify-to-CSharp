﻿using Music_Player.mainPackage;
using System.Windows.Forms;
using System.IO;


namespace Music_Player.userInterface
{
    class SearchBox
    {
        public static Button enterSearch;
        public static TextBox searchBox;
        WebScraper scraper = new WebScraper();
        Downloader d = new Downloader();
        public static Player player = new Player();
        //Pause pause = new Pause();
        bool firstSong = true;

        public void addSearch()
        {
            searchBox = new TextBox();
            enterSearch = new Button();
            enterSearch.Text = "Submit";
            enterSearch.SetBounds(Constants.windowWidth - 100, 5, 80, 25);
            enterSearch.Click += EnterSearch;
            enterSearch.Enter += EnterSearch;
            searchBox.SetBounds(5, 5, Constants.windowWidth - 100 - 25, 25);
            searchBox.Enter += EnterSearch;
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

                isUrl();

                string checkTitle = Constants.title;

                if(checkTitle.Contains("\\") || checkTitle.Contains("|"))
                {
                    checkTitle = checkTitle.Replace("\\", " ");
                    checkTitle = checkTitle.Replace("|", " ");
                }

                string song = Path.GetFullPath(Constants.songDownloadPath + "\\" + checkTitle + ".wav");


            }
        }

        public void isUrl()
        {
            if (searchBox.Text.Contains("https"))
            {
                Constants.url = searchBox.Text;
            }else
            {
                Constants.scraperURL = Constants.scraperURL + searchBox.Text;
                scraper.FindID();
                scraper.FindSongName();
            }
        } 
    }
}
