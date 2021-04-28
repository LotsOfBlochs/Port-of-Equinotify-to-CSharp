using System.Windows.Forms;

namespace Music_Player.userInterface
{
    class Pause
    {
        public static Button pause = new();
        double framePos;

        public static bool isPaused = false;
        
        public void addButton()
        {
            pause.Size = new System.Drawing.Size(80, 25);
            pause.AutoSize = true;
            pause.Text = "Pause";
            pause.Click += Pause_Click;
            BottomPanel.bottomPanel.Controls.Add(pause);

        }

        private void Pause_Click(object sender, System.EventArgs e)
        {
            if(sender == pause && !isPaused && SearchBox.player.player != null)
            {
                SearchBox.player.player.controls.pause();
                framePos = SearchBox.player.player.controls.currentPosition;
                pause.Text = "Play";
                isPaused = true;
            }else if(sender == pause && isPaused && SearchBox.player.player != null)
            {
                SearchBox.player.player.controls.play();
                pause.Text = "Pause";
                isPaused = false;
            }
        }
    }
}
