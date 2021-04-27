using Music_Player.mainPackage;
using System.Windows.Forms;
using System.Drawing;

namespace Music_Player.userInterface
{
    class Window
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
            while (true)
            {
                System.Threading.Thread.Sleep(new System.TimeSpan(0, 0, 10));
            }
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

        }
    }
}
