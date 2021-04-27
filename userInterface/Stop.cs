using Music_Player.mainPackage;
using System.Windows.Forms;

namespace Music_Player.userInterface
{
    class Stop
    {
        Button stopButton = new Button();

        public void addButton()
        {
            stopButton.Text = " Stop";
            stopButton.Click += StopButton_Click;
            BottomPanel.bottomPanel.Controls.Add(stopButton);
        }

        private void StopButton_Click(object sender, System.EventArgs e)
        {
            if(sender == stopButton)
            {
                SearchBox.player.player.controls.stop();
                SongName.songInfo.Text = "";
                //currentThumbnail 
                //thumbnailLabel
                SongLength.songLocation.Text = "00:00";
                SongLength.songLength.Text = "00:00";
            }
        }
    }
}
