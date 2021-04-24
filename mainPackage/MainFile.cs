using System.Threading;
using System;


namespace Music_Player.mainPackage
{
    class MainFile
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {
            MakeFile mf = new MakeFile();
            Downloader down = new Downloader();
            //UI ui = new UI();

            mf.dirGen();

            down.download_song();
            Thread.Sleep(new TimeSpan(0, 0, 15));
            down.download_thumbnail();
            //ui.startGuI();
            Player play = new Player();
            play.Music();
        }
    }
}
