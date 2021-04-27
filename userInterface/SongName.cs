using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music_Player.mainPackage;

namespace Music_Player.userInterface
{
    public class SongName
    {
        public static Label songInfo = new Label();

        public void displayInfo()
        {
            songInfo.Text = Constants.title;

            BottomPanel.bottomPanel.Controls.Add(songInfo);
        }
    }
}
