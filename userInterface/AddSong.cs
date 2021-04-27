using Music_Player.mainPackage;
using System.Windows.Forms;
using System.IO;

namespace Music_Player.userInterface
{
    class AddSong
    {
        Button addSong = new Button();

        public void addSongButton()
        {
            addSong.Text = "add";
            addSong.Click += AddSong_Click;
            BottomPanel.bottomPanel.Controls.Add(addSong);
        }

        private void AddSong_Click(object sender, System.EventArgs e)
        {
            string songFile = Path.GetFullPath(Constants.songDownloadPath + "\\" + Constants.title + ".wav");
            string playlist = Path.GetDirectoryName(Constants.songDownloadPath + "\\..\\playlists");

            if (!Directory.Exists(playlist))
            {
                Directory.CreateDirectory(playlist);
            }

            string songFileCopy = Path.GetFullPath(Constants.songDownloadPath + "\\..\\playlists\\" + Constants.title + ".wav");

            if(sender == addSong)
            {
                File.Copy(songFile, songFile);

                Constants.playlistSongTitles.Add(Constants.title);
                Constants.playlistSongPaths.Add(Constants.songDownloadPath + "\\" + Constants.title + ".wav");
            }
        }
    }
}
