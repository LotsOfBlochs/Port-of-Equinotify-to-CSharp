using System.Windows.Forms;
using System.Drawing;
using Music_Player.mainPackage;

namespace Music_Player.userInterface
{
    class TopPanel
    {
        public static Panel topPanel = new Panel();
        SearchBox searchBox = new SearchBox();

        public void init()
        {
            topPanel.BackColor = Color.White;
            topPanel.SetBounds(0, 0, Constants.windowWidth, 50);
            addComponents();
            Window.f.Controls.Add(topPanel);
        }

        public void addComponents()
        {
            searchBox.addSearch();
        }
    }
}
