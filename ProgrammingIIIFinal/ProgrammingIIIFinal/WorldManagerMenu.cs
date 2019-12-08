using ProgrammingIIIFinal.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingIIIFinal
{
    public partial class WorldManagerMenu : Form
    {
        WorldManagerLogIn parent;
        public WorldManagerMenu(WorldManagerLogIn parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        //By setting access modifier of menu buttons to internal, we are able to access the buttons to be used as paramaters for the enable method button with
        //parent.BtnMusicPlayer (this is one example)
        public void EnableButton(Button button) 
        {
            button.Enabled = true;
        }
        private void BtnMusicPlayer_Click(object sender, EventArgs e)
        {
            //Instantiate new form
            WorldManagerAmbientMusicPlayer worldManagerMusic = new WorldManagerAmbientMusicPlayer(this);
            //Disable music player button as it is being opened
            BtnMusicPlayer.Enabled = false;
            //Set this form as parent to new form
            worldManagerMusic.Owner = this;
            //Show the form (non-modal) this means that the user can still access the menu whilst using the music player.
            worldManagerMusic.Show();
            
        }

        private void BtnPlayerInformation_Click(object sender, EventArgs e)
        {
            //Instantiate new form 
            WorldManagerPlayerInformation worldManagerPlayer = new WorldManagerPlayerInformation(this);
            //Disable Player Information button as it is being opened
            BtnPlayerInformation.Enabled = false;
            //Set this form as parent to new form
            worldManagerPlayer.Owner = this;
            //Show form (non-modal) so various functions of the program can be accessed
            worldManagerPlayer.Show();
        }

        private void BtnDiceRoller_Click(object sender, EventArgs e)
        {
            //Instantiate new form 
            WorldManagerDiceRoller worldManagerDice = new WorldManagerDiceRoller(this);
            //Disable Dice roller button as it is being opened
            BtnDiceRoller.Enabled = false;
            //Set this form as parent to new form
            worldManagerDice.Owner = this;
            //Show form (non-modal) so various functions of the program can be accessed
            worldManagerDice.Show();
        }

        private void BtnSpellReference_Click(object sender, EventArgs e)
        {
            //Instantiate new form
            WorldManagerSpellCompendium worldManagerSpells = new WorldManagerSpellCompendium(this);
            //Disable Spell Compendium button as it is being opened
            BtnSpellReference.Enabled = false;
            //Set this form as parent to the new form
            worldManagerSpells.Owner = this;
            //Show form (non-modal) so various functions of the program can be accessed
            worldManagerSpells.Show();
        }
        //Closes the program
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            parent.Show();
            parent.toolStripStatusLabel1.Text = "Welcome, Please Enter Your Information to Log-In";
            parent.TbUserName.Text = "";
            parent.TbPassword.Text = "";
            this.Hide();
        }
    }
}
