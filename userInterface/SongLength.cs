using Music_Player.mainPackage;
using System.Windows.Forms;

namespace Music_Player.userInterface
{
    class SongLength
    {
        public static Label songLength = new Label();
        public static Label songLocation = new Label();
        public static Label colon = new Label();

        public void displayLength()
        {
            songLength.Text = "00:00";
            colon.Text = "|";
            songLocation.Text = "00:00";
            BottomPanel.bottomPanel.Controls.Add(songLocation);
            BottomPanel.bottomPanel.Controls.Add(colon);
            BottomPanel.bottomPanel.Controls.Add(songLength);
        }
    }
}
