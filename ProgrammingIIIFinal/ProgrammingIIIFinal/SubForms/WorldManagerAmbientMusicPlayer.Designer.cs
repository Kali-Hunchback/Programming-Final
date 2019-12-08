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
            this.GbControlGroup = new System.Windows.Forms.GroupBox();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.GbControlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(159, 38);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(629, 211);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // LbSongs
            // 
            this.LbSongs.FormattingEnabled = true;
            this.LbSongs.Location = new System.Drawing.Point(12, 255);
            this.LbSongs.Name = "LbSongs";
            this.LbSongs.Size = new System.Drawing.Size(775, 134);
            this.LbSongs.TabIndex = 1;
            // 
            // BtnImportSongs
            // 
            this.BtnImportSongs.Location = new System.Drawing.Point(13, 395);
            this.BtnImportSongs.Name = "BtnImportSongs";
            this.BtnImportSongs.Size = new System.Drawing.Size(124, 43);
            this.BtnImportSongs.TabIndex = 2;
            this.BtnImportSongs.Text = "Import Songs";
            this.BtnImportSongs.UseVisualStyleBackColor = true;
            this.BtnImportSongs.Click += new System.EventHandler(this.BtnImportSongs_Click);
            // 
            // GbControlGroup
            // 
            this.GbControlGroup.Controls.Add(this.BtnForward);
            this.GbControlGroup.Controls.Add(this.BtnLast);
            this.GbControlGroup.Controls.Add(this.BtnBack);
            this.GbControlGroup.Controls.Add(this.BtnFirst);
            this.GbControlGroup.Location = new System.Drawing.Point(12, 38);
            this.GbControlGroup.Name = "GbControlGroup";
            this.GbControlGroup.Size = new System.Drawing.Size(125, 211);
            this.GbControlGroup.TabIndex = 3;
            this.GbControlGroup.TabStop = false;
            this.GbControlGroup.Text = "Media Player Controls";
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(7, 20);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(113, 42);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "Play First";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(6, 68);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(113, 42);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back One Song";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(7, 164);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(113, 42);
            this.BtnLast.TabIndex = 0;
            this.BtnLast.Text = "Play Last";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.Location = new System.Drawing.Point(6, 116);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(113, 42);
            this.BtnForward.TabIndex = 0;
            this.BtnForward.Text = "Forward One Song";
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // WorldManagerAmbientMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GbControlGroup);
            this.Controls.Add(this.BtnImportSongs);
            this.Controls.Add(this.LbSongs);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "WorldManagerAmbientMusicPlayer";
            this.Text = "WorldManagerAmbientMusicPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldManagerAmbientMusicPlayer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.GbControlGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox LbSongs;
        private System.Windows.Forms.Button BtnImportSongs;
        private System.Windows.Forms.GroupBox GbControlGroup;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnFirst;
    }
}