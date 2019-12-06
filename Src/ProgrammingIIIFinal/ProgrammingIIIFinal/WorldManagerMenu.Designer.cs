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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMusicPlayer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnSpellReference = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnDiceRoller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnMusicPlayer
            // 
            this.BtnMusicPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusicPlayer.Location = new System.Drawing.Point(18, 31);
            this.BtnMusicPlayer.Name = "BtnMusicPlayer";
            this.BtnMusicPlayer.Size = new System.Drawing.Size(610, 66);
            this.BtnMusicPlayer.TabIndex = 1;
            this.BtnMusicPlayer.Text = "Ambient Music Player";
            this.BtnMusicPlayer.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(610, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Player Information";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnSpellReference
            // 
            this.BtnSpellReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpellReference.Location = new System.Drawing.Point(18, 176);
            this.BtnSpellReference.Name = "BtnSpellReference";
            this.BtnSpellReference.Size = new System.Drawing.Size(610, 69);
            this.BtnSpellReference.TabIndex = 3;
            this.BtnSpellReference.Text = "Spell Compendium";
            this.BtnSpellReference.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(18, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(610, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Landmark Compendium";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnDiceRoller
            // 
            this.BtnDiceRoller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiceRoller.Location = new System.Drawing.Point(18, 323);
            this.BtnDiceRoller.Name = "BtnDiceRoller";
            this.BtnDiceRoller.Size = new System.Drawing.Size(610, 74);
            this.BtnDiceRoller.TabIndex = 5;
            this.BtnDiceRoller.Text = "Dice Roller";
            this.BtnDiceRoller.UseVisualStyleBackColor = true;
            // 
            // WorldManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.BtnDiceRoller);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnSpellReference);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnMusicPlayer);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorldManagerMenu";
            this.Text = "World Manager Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnMusicPlayer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnSpellReference;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnDiceRoller;
    }
}