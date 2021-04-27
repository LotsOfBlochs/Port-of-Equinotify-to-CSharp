using System;
using System.IO;
using WMPLib;
using Music_Player.userInterface;

namespace Music_Player.mainPackage
{
    class Player
    {
        public static bool songPlaying = true;
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        public void Music()
        {
            string file = Path.GetFullPath(Constants.songDownloadPath + "\\" + Constants.title + ".wav");
            player.URL = file;
            SongLength.songLength.Text = TimeSpan.FromSeconds(player.controls.currentItem.duration).ToString();
            player.PositionChange += new _WMPOCXEvents_PositionChangeEventHandler(Player_PositionChange);
            player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChanged);
            player.controls.play();
            while (songPlaying)
            {
                System.Threading.Thread.Sleep(new TimeSpan(0, 0, 1));
            }
        }

        private void Player_PlayStateChanged(int NewState)
        {
            if(NewState == 1) { songPlaying = false; }
        }

        private void Player_PositionChange(double oldPosition, double newPosition)
        {
            SongLength.songLocation.Text = TimeSpan.FromSeconds(player.controls.currentPosition).ToString();
        }

    }
}