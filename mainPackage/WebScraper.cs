using AngleSharp;


namespace Music_Player.mainPackage
{
    class WebScraper
    {
        public async void FindID()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.youtube.com/results?search_query=merci+stephane+legar";
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address);
            string web = document.DocumentElement.OuterHtml;
            for(int i = 0; i < web.Length; i++)
            {
                if(web.Substring(i, i + 7).Equals(" videoID"))
                {
                    Constants.id = web.Substring(i + 10, 1 + 21);
                    break;
                }
            }
        }

        public async void FindSongName()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.youtube.com/results?search_query=merci+stephane+legar";
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address);
            string web = document.DocumentElement.OuterHtml;
            for (int i = 0; i < web.Length; i++)
            {
                if (web.Substring(i, i + 14).Equals("title\":{\"runs\""))
                {
                    bool grabbingTitle = true;
                    for (int n = 1, j = 0; grabbingTitle; n++, j++)
                    {
                        if(!web.Substring(i + 25 + j, i + 25 + n).Equals("\"")){
                            Constants.title = Constants.title + web.Substring(i + 25 + j, i + 25 + n);
                        }else if (web.Substring(i + 25 + j, i + 25 + n).Equals("\""))
                        {
                            grabbingTitle = false;
                        }
                    }
                    break;
                }
            }
        }
    }
}
