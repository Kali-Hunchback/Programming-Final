namespace ProgrammingIIIFinal
{
    partial class WorldManagerPlayerInformation
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
            this.DgvPlayers = new System.Windows.Forms.DataGridView();
            this.BtnLoadInformation = new System.Windows.Forms.Button();
            this.BtnSaveInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPlayers
            // 
            this.DgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlayers.Location = new System.Drawing.Point(12, 49);
            this.DgvPlayers.Name = "DgvPlayers";
            this.DgvPlayers.Size = new System.Drawing.Size(776, 389);
            this.DgvPlayers.TabIndex = 0;
            // 
            // BtnLoadInformation
            // 
            this.BtnLoadInformation.Location = new System.Drawing.Point(13, 13);
            this.BtnLoadInformation.Name = "BtnLoadInformation";
            this.BtnLoadInformation.Size = new System.Drawing.Size(174, 23);
            this.BtnLoadInformation.TabIndex = 1;
            this.BtnLoadInformation.Text = "Load Character Information";
            this.BtnLoadInformation.UseVisualStyleBackColor = true;
            // 
            // BtnSaveInformation
            // 
            this.BtnSaveInformation.Location = new System.Drawing.Point(205, 12);
            this.BtnSaveInformation.Name = "BtnSaveInformation";
            this.BtnSaveInformation.Size = new System.Drawing.Size(169, 23);
            this.BtnSaveInformation.TabIndex = 2;
            this.BtnSaveInformation.Text = "Save Character Information";
            this.BtnSaveInformation.UseVisualStyleBackColor = true;
            // 
            // WorldManagerPlayerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSaveInformation);
            this.Controls.Add(this.BtnLoadInformation);
            this.Controls.Add(this.DgvPlayers);
            this.Name = "WorldManagerPlayerInformation";
            this.Text = "WorldManagerPlayerInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldManagerPlayerInformation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPlayers;
        private System.Windows.Forms.Button BtnLoadInformation;
        private System.Windows.Forms.Button BtnSaveInformation;
    }
}