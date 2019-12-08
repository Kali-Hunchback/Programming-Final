using System;
using System.Windows.Forms;

namespace ProgrammingIIIFinal
{
    public partial class WorldManagerAmbientMusicPlayer : Form
    {
        private WorldManagerMenu parent;
        public WorldManagerAmbientMusicPlayer(WorldManagerMenu parent)
        {
            InitializeComponent();
            //Reference this form as a child of Menu on form load to enable button 
            //activation in menu from this form
            this.parent = parent;
        }

        //Re-enable parent form button on close
        private void WorldManagerAmbientMusicPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.EnableButton(parent.BtnMusicPlayer);
        }
    }
}
