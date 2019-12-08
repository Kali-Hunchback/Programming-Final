namespace ProgrammingIIIFinal
{
    partial class WorldManagerAmbientMusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldManagerAmbientMusicPlayer));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.LbSongs = new System.Windows.Forms.ListBox();
            this.BtnImportSongs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(13, 13);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(775, 199);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // LbSongs
            // 
            this.LbSongs.FormattingEnabled = true;
            this.LbSongs.Location = new System.Drawing.Point(13, 219);
            this.LbSongs.Name = "LbSongs";
            this.LbSongs.Size = new System.Drawing.Size(775, 134);
            this.LbSongs.TabIndex = 1;
            // 
            // BtnImportSongs
            // 
            this.BtnImportSongs.Location = new System.Drawing.Point(13, 360);
            this.BtnImportSongs.Name = "BtnImportSongs";
            this.BtnImportSongs.Size = new System.Drawing.Size(124, 43);
            this.BtnImportSongs.TabIndex = 2;
            this.BtnImportSongs.Text = "Import Songs";
            this.BtnImportSongs.UseVisualStyleBackColor = true;
            // 
            // WorldManagerAmbientMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnImportSongs);
            this.Controls.Add(this.LbSongs);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "WorldManagerAmbientMusicPlayer";
            this.Text = "WorldManagerAmbientMusicPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldManagerAmbientMusicPlayer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox LbSongs;
        private System.Windows.Forms.Button BtnImportSongs;
    }
}