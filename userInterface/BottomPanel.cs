using Music_Player.mainPackage;
using System.Windows.Forms;
using System.Drawing;

namespace Music_Player.userInterface
{
    public class BottomPanel
    { 
        public static int bottomPanelY = Constants.windowHeight - 100;
        public static Panel bottomPanel = new Panel();
        Pause pauseButton = new Pause();
        public static SongName songName = new SongName();
        AddSong addSong = new AddSong();
        Stop stopButton = new Stop();
        //VolumeSlider volSlider = new VolumeSlider(); //TODO: Maybe add Volume Slider
        SongLength songLength = new SongLength();

        public void init()
        {
            bottomPanel.BackColor = Color.White;
            bottomPanel.SetBounds(0, bottomPanelY, Constants.windowWidth, 500);
        }

        public void addComponents()
        {
            stopButton.addButton();
            pauseButton.addButton();
            songName.displayInfo();
            addSong.addSongButton();
            songLength.displayLength();
        }
        
    }
}