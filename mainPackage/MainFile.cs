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


            //ui.startGuI();
            
        }
    }
}
