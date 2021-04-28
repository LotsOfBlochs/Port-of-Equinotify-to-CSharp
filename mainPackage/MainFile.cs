using Music_Player.userInterface;

namespace Music_Player.mainPackage
{
    class MainFile
    {
        static void Main(string[] args)
        {
            start();
        }

        public static void start()
        {
            MakeFile mf = new MakeFile();
            UI ui = new UI();

            mf.dirGen();
            ui.startGUI();
            
        }
    }
}
