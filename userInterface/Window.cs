using Music_Player.mainPackage;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Music_Player.userInterface
{
    class Window : Form
    {
        public static Form f = new Form();

        BottomPanel bottomPanel = new BottomPanel();
        TopPanel topPanel = new TopPanel();
        //LeftPanel leftPanel = new LeftPanel();
        //MainPanel mainPanel = new MainPanel();

        public void drawWindow()
        {
            f.SetBounds(0, 0, Constants.windowWidth, Constants.windowHeight);
            f.Text = "Equinotify";
            Icon ico = Music_Player.Properties.Resources.Icon1;
            f.Icon = ico;
            drawPanels();
            f.Show();
            f.Resize += f_Resize;
            Application.Run(f);
            //while (true){}
        }

        public void drawPanels() {
            bottomPanel.init();
            topPanel.init();
            //leftPanel.init();
            //mainPanel.init();
        }

        private void f_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;

            f.SetBounds(0, 0, f.Width, f.Height);
            Constants.windowWidth = f.Width;
            Constants.windowHeight = f.Height;
            redrawPanels();
        }
        public void redrawPanels()
        {
            BottomPanel.bottomPanel.SetBounds(0, f.Height - 100, f.Width, 61);
            TopPanel.topPanel.SetBounds(0, 0, f.Width, 35);
            SearchBox.searchBox.SetBounds(5,5, f.Width - 105, f.Height - 132);
            SearchBox.enterSearch.SetBounds(f.Width - 100, 5, 80, 25);
        }
    }
}
