using System;
using System.IO;
using System.Media;

namespace Music_Player.mainPackage
{
    class Player
    {

        public void Music()
        {
            string file = Path.GetFullPath(Constants.songDownloadPath + "\\" + Constants.title + ".wav");

            SoundPlayer player = new SoundPlayer();

            // Listen for the SoundLocationChanged event.
            //player.SoundLocationChanged += new EventHandler(player_LocationChanged);
            player.SoundLocation = file;
            player.Play();
        }

        private void player_LocationChanged(object sender, EventArgs e)
        {
            //string min = ToString(TimeUnit);
        }
    }
}