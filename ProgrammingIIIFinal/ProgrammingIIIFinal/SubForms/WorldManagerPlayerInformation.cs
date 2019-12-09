using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProgrammingIIIFinal
{
    public partial class WorldManagerPlayerInformation : Form
    {
        private WorldManagerMenu parent;
        public WorldManagerPlayerInformation(WorldManagerMenu parent)
        {
            InitializeComponent();
            //Reference this form as a child of Menu on form load to enable button 
            //activation in menu from this form
            this.parent = parent;
        }
        //Enable related button when child form closes.
        private void WorldManagerPlayerInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.EnableButton(parent.BtnPlayerInformation);
        }


        private void BtnLoadInformation_Click(object sender, EventArgs e)
        {
            //Create OpenFileDialog which enables targetting an input directory
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                //Open Fileselector, if Ok dialog is used, then the block will continue
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //Create StreamReader which target selected directory formed from parent block
                    var streamReader = new StreamReader(new FileStream(openFile.FileName, FileMode.Open));
                    //Create CsvReader using the template fed to it by the streamReader
                    var CsvReader = new CsvReader(streamReader);
                    //Create var which stores method call for CSV Reader
                    var results = CsvReader.GetRecords<Player>();
                    //Set the datasource of the bound data equal to the return of getRecord
                    playerBindingSource.DataSource = results;
                    MessageBox.Show("Your data was read in completion", "Success!", MessageBoxButtons.OK);
                }
            }
        }
        private void BtnSaveInformation_Click(object sender, EventArgs e)
        {
            //Create SaveFileDialog which enables targetting an output directory
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                //Open Fileselector, if Ok dialog is used, then the block will continue
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //Create StreamWriter which target selected directory formed from parent block
                    using (var streamWriter = new StreamWriter(saveFile.FileName))
                    {
                        //Create CsvWriter using the template fed to it by the streamWriter
                        using (var CsvWriter = new CsvWriter(streamWriter))
                        {
                            CsvWriter.WriteHeader(typeof(Player));
                            CsvWriter.NextRecord();
                            CsvWriter.WriteRecords(playerBindingSource);
                        }
                    }
                    //Alert user to success
                    MessageBox.Show("Your Data was Saved Successfully", "Success!", MessageBoxButtons.OK);
                }
            }
        }

        private void WorldManagerPlayerInformation_Load(object sender, EventArgs e)
        {
            //Allow users to add row in both output element and the binding source as well as 
            //create a list to manage the incoming data inside of the Data Grid View
            DgvPlayers.AllowUserToAddRows = true;
            playerBindingSource.AllowNew = true;
            List<Player> playerList = new List<Player>();
            playerBindingSource.DataSource = playerList;
        }
    }
}
