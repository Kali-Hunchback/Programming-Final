namespace ProgrammingIIIFinal
{
    partial class WorldManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldManagerMenu));
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnMusicPlayer = new System.Windows.Forms.Button();
            this.BtnPlayerInformation = new System.Windows.Forms.Button();
            this.BtnSpellReference = new System.Windows.Forms.Button();
            this.BtnDiceRoller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(571, 396);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(57, 42);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.Text = "Log-Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnMusicPlayer
            // 
            this.BtnMusicPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusicPlayer.Location = new System.Drawing.Point(18, 12);
            this.BtnMusicPlayer.Name = "BtnMusicPlayer";
            this.BtnMusicPlayer.Size = new System.Drawing.Size(610, 90);
            this.BtnMusicPlayer.TabIndex = 1;
            this.BtnMusicPlayer.Text = "Ambient Music Player";
            this.BtnMusicPlayer.UseVisualStyleBackColor = true;
            this.BtnMusicPlayer.Click += new System.EventHandler(this.BtnMusicPlayer_Click);
            // 
            // BtnPlayerInformation
            // 
            this.BtnPlayerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayerInformation.Location = new System.Drawing.Point(18, 108);
            this.BtnPlayerInformation.Name = "BtnPlayerInformation";
            this.BtnPlayerInformation.Size = new System.Drawing.Size(610, 90);
            this.BtnPlayerInformation.TabIndex = 2;
            this.BtnPlayerInformation.Text = "Player Information";
            this.BtnPlayerInformation.UseVisualStyleBackColor = true;
            this.BtnPlayerInformation.Click += new System.EventHandler(this.BtnPlayerInformation_Click);
            // 
            // BtnSpellReference
            // 
            this.BtnSpellReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpellReference.Location = new System.Drawing.Point(18, 204);
            this.BtnSpellReference.Name = "BtnSpellReference";
            this.BtnSpellReference.Size = new System.Drawing.Size(610, 90);
            this.BtnSpellReference.TabIndex = 3;
            this.BtnSpellReference.Text = "Spell Compendium";
            this.BtnSpellReference.UseVisualStyleBackColor = true;
            this.BtnSpellReference.Click += new System.EventHandler(this.BtnSpellReference_Click);
            // 
            // BtnDiceRoller
            // 
            this.BtnDiceRoller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiceRoller.Location = new System.Drawing.Point(18, 300);
            this.BtnDiceRoller.Name = "BtnDiceRoller";
            this.BtnDiceRoller.Size = new System.Drawing.Size(610, 90);
            this.BtnDiceRoller.TabIndex = 5;
            this.BtnDiceRoller.Text = "Dice Roller";
            this.BtnDiceRoller.UseVisualStyleBackColor = true;
            this.BtnDiceRoller.Click += new System.EventHandler(this.BtnDiceRoller_Click);
            // 
            // WorldManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.BtnDiceRoller);
            this.Controls.Add(this.BtnSpellReference);
            this.Controls.Add(this.BtnPlayerInformation);
            this.Controls.Add(this.BtnMusicPlayer);
            this.Controls.Add(this.BtnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorldManagerMenu";
            this.Text = "World Manager Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogOut;
        internal System.Windows.Forms.Button BtnMusicPlayer;
        internal System.Windows.Forms.Button BtnPlayerInformation;
        internal System.Windows.Forms.Button BtnSpellReference;
        internal System.Windows.Forms.Button BtnDiceRoller;
    }
}