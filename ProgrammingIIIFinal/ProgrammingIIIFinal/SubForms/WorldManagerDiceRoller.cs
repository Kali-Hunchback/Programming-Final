using System.Windows.Forms;

namespace ProgrammingIIIFinal.SubForms
{
    public partial class WorldManagerDiceRoller : Form
    {
        private WorldManagerMenu parent;
        public WorldManagerDiceRoller(WorldManagerMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        //Enable button when child form closes
        private void WorldManagerDiceRoller_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.EnableButton(parent.BtnDiceRoller);
        }
    }
}
