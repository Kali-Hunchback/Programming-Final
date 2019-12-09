using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProgrammingIIIFinal
{
    public partial class WorldManagerSpellCompendium : Form
    {
        
        //File destination for read write functions
        string spellBinary = "spells.dat";
        private WorldManagerMenu parent;
        public WorldManagerSpellCompendium(WorldManagerMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        
        //Create list to facilitate spell storage and user access
        List<Spell> spellList = new List<Spell>();
        //enable menu button on form close
        private void WorldManagerSpellCompendium_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.EnableButton(parent.BtnSpellReference);
        }
        //Clears all text boxes after a spell is added
        public void ClearTB()
        {
            TbSearch.Clear();
            TbName.Clear();
            TbLevel.Clear();
            TbSchool.Clear();
            TbTime.Clear();
            TbRange.Clear();
            TbComponents.Clear();
            TbDuration.Clear();
            TbAvailableClass.Clear();
            TbDescription.Clear();
        }
        //Method to add a spell to the list
        private void BtnAddSpell_Click(object sender, EventArgs e)
        {
            //If any spell information boxes are empty, prompt user of error. 
            if (string.IsNullOrEmpty(TbName.Text) || string.IsNullOrEmpty(TbLevel.Text) || string.IsNullOrEmpty(TbSchool.Text) ||
                string.IsNullOrEmpty(TbTime.Text) || string.IsNullOrEmpty(TbRange.Text) || string.IsNullOrEmpty(TbComponents.Text) ||
                string.IsNullOrEmpty(TbDuration.Text) || string.IsNullOrEmpty(TbAvailableClass.Text) || string.IsNullOrEmpty(TbDescription.Text))
            {
                MessageBox.Show("Please enter information into all text boxes excluding search in order to add a Spell to the list", "Please try again!", MessageBoxButtons.OK);
            }
            //If all spell information boxes are populated create new spell, insert into listBox, Clear textboxes, add spell to spellList
            else if ((!string.IsNullOrEmpty(TbName.Text) && !string.IsNullOrEmpty(TbLevel.Text) && !string.IsNullOrEmpty(TbSchool.Text) &&
                !string.IsNullOrEmpty(TbTime.Text) && !string.IsNullOrEmpty(TbRange.Text) && !string.IsNullOrEmpty(TbComponents.Text) &&
                !string.IsNullOrEmpty(TbDuration.Text) && !string.IsNullOrEmpty(TbAvailableClass.Text) && !string.IsNullOrEmpty(TbDescription.Text)))
            {
                Spell newSpell = new Spell(TbName.Text, TbLevel.Text, TbSchool.Text, 
                    TbTime.Text, TbRange.Text, TbComponents.Text, 
                    TbDuration.Text, TbAvailableClass.Text, TbDescription.Text);
                LbSpellBox.Items.Add(TbName.Text);
                ClearTB();
                spellList.Add(newSpell);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnSortSpells_Click(object sender, EventArgs e)
        {
            /*spellList.Sort();
            LbSpellBox.Items.Clear();
            foreach (Spell s in spellList) 
            {
              LbSpellBox.Items.Add(s.ToString());
            }*/


        }

        private void LbSpellBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //instantiate object class
            Spell spell;
            int index = LbSpellBox.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Invalid Index", "ERROR", MessageBoxButtons.OK);
            }
            else 
            {
                spell = spellList[index];
                TbName.Text = spellList[index].spellName;
                TbLevel.Text = spellList[index].spellLevel;
                TbSchool.Text = spellList[index].spellSchool;
                TbTime.Text = spellList[index].castTime;
                TbRange.Text = spellList[index].spellRange;
                TbComponents.Text = spellList[index].spellComponents;
                TbDuration.Text = spellList[index].spellDuration;
                TbAvailableClass.Text = spellList[index].spellClasses;
                TbDescription.Text = spellList[index].spellDescription;
            }
        }

        private void WorldManagerSpellCompendium_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stores spells in spell.dat.
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(spellBinary, FileMode.Create)))
                {
                    for (int i = 0; i < spellList.Count; i++)
                    {
                        //write fields for spells inside of the file
                        writer.Write(spellList[i].spellName);
                        writer.Write(spellList[i].spellLevel);
                        writer.Write(spellList[i].spellSchool);
                        writer.Write(spellList[i].castTime);
                        writer.Write(spellList[i].spellRange);
                        writer.Write(spellList[i].spellComponents);
                        writer.Write(spellList[i].spellDuration);
                        writer.Write(spellList[i].spellClasses);
                        writer.Write(spellList[i].spellDescription);
                    }
                    MessageBox.Show("Your spells were saved successfully");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("There was an issue writing to the spell list" + ex);
            }
        }

        private void WorldManagerSpellCompendium_Load(object sender, EventArgs e)
        {
            //Load spell binary file created on form close from first run
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(spellBinary, FileMode.Open)))
                {
                    if (File.Exists(spellBinary))
                    {
                        while (reader.PeekChar() != -1)
                        {
                            Spell newSpell = new Spell(reader.ReadString(), reader.ReadString(), reader.ReadString(),
                                reader.ReadString(), reader.ReadString(), reader.ReadString(),
                                reader.ReadString(), reader.ReadString(), reader.ReadString());
                            spellList.Add(newSpell);
                            LbSpellBox.Items.Add(newSpell.spellName);
                        }
                    }
                }
            }
            catch (IOException ex) 
            {
                MessageBox.Show("An error has occured on loading the spell list" + ex, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
