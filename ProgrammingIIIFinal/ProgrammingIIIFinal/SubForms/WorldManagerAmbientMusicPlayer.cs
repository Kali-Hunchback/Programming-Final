using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

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

        //Creates linked list (C# is inately double-linked list structure) to store songs into
        LinkedList<string> songList = new LinkedList<string>();
        //Creates global string variable to store song URL to be accessed by WMP
        string song = null;

        //Display method for song, copies information from the LinkedList<string>,
        //populates the LbSongList element using a foreach loop after clearing it's items.
        public void DisplaySongs() 
        {
            LbSongs.Items.Clear();
            foreach (string path in songList) 
            {
                LbSongs.Items.Add(path);
            }
        }

        //Play method used to interact with the WMP element that is on the form.
        public void Play(string path)
        {
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        //Plays the song from the first node of the LinkedList<string> structure.
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            Play(songList.First.Value);
            song = songList.First.Value;
        }
        //Plays the song stored one node currently before the selected song from the LinkedList<string> structure
        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedSong = axWindowsMediaPlayer1.URL;
                string loadingSong = songList.Find(selectedSong).Previous.Value;
                Play(loadingSong);
            }
            //Catch any exception thrown by the method
            catch (Exception x)
            {
                MessageBox.Show("An Exception has occured" + x.Message, "Exception!");
            }
        }
        //Plays the song stored one node currently after the selected song from the LinkedList<string> structure
        private void BtnForward_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedSong = axWindowsMediaPlayer1.URL;
                string loadingSong = songList.Find(selectedSong).Next.Value;
                Play(loadingSong);
            }
            //Catch any exception thrown by the method.
            catch (Exception x)
            {
                MessageBox.Show("An Exception has occured" + x.Message, "Exception!");
            }
        }
        //Plays the song from the last node of the LinkedList<string> structure.
        private void BtnLast_Click(object sender, EventArgs e)
        {
            Play(songList.Last.Value);
            song = songList.Last.Value;
        }

        private void BtnImportSongs_Click(object sender, EventArgs e)
        {
            try
            {
                //Create method wide var's which will act as a storage for the neccassary path and content information to be opened by OpenFileDialog
                var fileContent = string.Empty;
                var pathName = string.Empty;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    //Using Openfile dialog, target the users Environment UserName and their Music folder stored in the music file
                    //Files targeted are of .mp3 format
                    openFileDialog.InitialDirectory = @"c:\users\" + Environment.UserName + @"\Music";
                    openFileDialog.Filter = "Music Files (*.mp3)|*.mp3";
                    //Filter applies to filter option one(mp3)
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get file path
                        pathName = openFileDialog.FileName;
                        //Add song to LinkedList as Last item.
                        songList.AddLast(pathName);
                        //Read file Contents
                        var fileStream = openFileDialog.OpenFile();
                        //Reads the song into the program using StreamReader and then disposes the StreamReader object when reading is complete due to the "using" key word
                        using (StreamReader streamReader = new StreamReader(fileStream))
                        {
                            fileContent = streamReader.ReadToEnd();
                        }

                    }
                    //Dispose of components held by the openFileDialog
                    openFileDialog.Dispose();
                }
                //Display the songs into the listBox, making them playable
                DisplaySongs();
            }
            //Catch any exceptions caused by the method
            catch (Exception x)
            {
                MessageBox.Show("An Exception has occured" + x.Message, "Exception!");
            }
        }
    }
}
