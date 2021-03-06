using AngleSharp;


namespace Music_Player.mainPackage
{
    class WebScraper
    {
        static string id = "";
        static string title = "";
        public async System.Threading.Tasks.Task<string> FindIDAsync()
        {
            id = "";
            var config = Configuration.Default.WithDefaultLoader();
            var address = Constants.scraperURL;
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address);
            string web = document.DocumentElement.OuterHtml;
            for(int i = 0; i < web.Length; i++)
            {
                if(web.Substring(i, i + 7).Equals(" videoID"))
                {
                    string id = web.Substring(i + 10, 1 + 21);
                    break;
                }
            }
            return id;
        }

        public async System.Threading.Tasks.Task<string> FindSongName()
        {
            title = "";
            var config = Configuration.Default.WithDefaultLoader();
            var address = Constants.scraperURL;
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
                            title = title + web.Substring(i + 25 + j, i + 25 + n);
                        }else if (web.Substring(i + 25 + j, i + 25 + n).Equals("\""))
                        {
                            grabbingTitle = false;
                        }
                    }
                    break;
                }
            }
            return title;
        }
    }
}
