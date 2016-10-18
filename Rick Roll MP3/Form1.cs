using System.Windows.Forms;
using WMPLib;
using System.IO;


namespace Rick_Roll_MP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Troll();
        }
        public void Troll()
        {
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = Path.Combine(Directory.GetCurrentDirectory() + "\\Song.mp3") ;
            myplayer.controls.play();
        }
    }
}
