using System;
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
        //Create random to instantiate various dice
        Random random = new Random();
        //Roll 4 sided dice
        private void BtnD4_Click(object sender, EventArgs e)
        {
            int roll = random.Next(1, 5);
            TbD2.Text = roll.ToString();
        }
        //Roll 6 sided dice
        private void BtnD6_Click(object sender, EventArgs e)
        {
            int roll = random.Next(1, 7);
            TbD6.Text = roll.ToString();
        }
        //Roll 8 sided dice
        private void BtnD8_Click(object sender, EventArgs e)
        {
            int roll = random.Next(1, 9);
            TbD8.Text = roll.ToString();
        }
        //Roll 10 sided dice
        private void BtnD10_Click(object sender, EventArgs e)
        {
            int roll = random.Next(1, 11);
            TbD10.Text = roll.ToString();
        }
        //Roll 12 sided dice
        private void BtnD12_Click(object sender, EventArgs e)
        {
            int roll = random.Next(1, 13);
            TbD12.Text = roll.ToString();
        }
        //Roll 20 sided dice
        private void BtnD20_Click(object sender, EventArgs e)
        {
            int roll = random.Next(1, 21);
            TbD20.Text = roll.ToString();
        }
        //Roll percentile dice (Value between 0 and 100%)
        private void BtnD100_Click(object sender, EventArgs e)
        {
            int roll = random.Next(0, 101);
            TbD100.Text = roll.ToString();
        }
    }
}
