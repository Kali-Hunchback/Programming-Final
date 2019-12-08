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
            this.components = new System.ComponentModel.Container();
            this.DgvPlayers = new System.Windows.Forms.DataGridView();
            this.BtnLoadInformation = new System.Windows.Forms.Button();
            this.BtnSaveInformation = new System.Windows.Forms.Button();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experiencePointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPlayers
            // 
            this.DgvPlayers.AutoGenerateColumns = false;
            this.DgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.characterNameDataGridViewTextBoxColumn,
            this.characterClassDataGridViewTextBoxColumn,
            this.characterLevelDataGridViewTextBoxColumn,
            this.experiencePointsDataGridViewTextBoxColumn});
            this.DgvPlayers.DataSource = this.playerBindingSource;
            this.DgvPlayers.Location = new System.Drawing.Point(12, 49);
            this.DgvPlayers.Name = "DgvPlayers";
            this.DgvPlayers.RowHeadersWidth = 50;
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
            this.BtnLoadInformation.Click += new System.EventHandler(this.BtnLoadInformation_Click);
            // 
            // BtnSaveInformation
            // 
            this.BtnSaveInformation.Location = new System.Drawing.Point(205, 12);
            this.BtnSaveInformation.Name = "BtnSaveInformation";
            this.BtnSaveInformation.Size = new System.Drawing.Size(169, 23);
            this.BtnSaveInformation.TabIndex = 2;
            this.BtnSaveInformation.Text = "Save Character Information";
            this.BtnSaveInformation.UseVisualStyleBackColor = true;
            this.BtnSaveInformation.Click += new System.EventHandler(this.BtnSaveInformation_Click);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ProgrammingIIIFinal.Player);
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "playerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "playerName";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.Width = 157;
            // 
            // characterNameDataGridViewTextBoxColumn
            // 
            this.characterNameDataGridViewTextBoxColumn.DataPropertyName = "characterName";
            this.characterNameDataGridViewTextBoxColumn.HeaderText = "characterName";
            this.characterNameDataGridViewTextBoxColumn.Name = "characterNameDataGridViewTextBoxColumn";
            this.characterNameDataGridViewTextBoxColumn.Width = 153;
            // 
            // characterClassDataGridViewTextBoxColumn
            // 
            this.characterClassDataGridViewTextBoxColumn.DataPropertyName = "characterClass";
            this.characterClassDataGridViewTextBoxColumn.HeaderText = "characterClass";
            this.characterClassDataGridViewTextBoxColumn.Name = "characterClassDataGridViewTextBoxColumn";
            this.characterClassDataGridViewTextBoxColumn.Width = 153;
            // 
            // characterLevelDataGridViewTextBoxColumn
            // 
            this.characterLevelDataGridViewTextBoxColumn.DataPropertyName = "characterLevel";
            this.characterLevelDataGridViewTextBoxColumn.HeaderText = "characterLevel";
            this.characterLevelDataGridViewTextBoxColumn.Name = "characterLevelDataGridViewTextBoxColumn";
            this.characterLevelDataGridViewTextBoxColumn.Width = 153;
            // 
            // experiencePointsDataGridViewTextBoxColumn
            // 
            this.experiencePointsDataGridViewTextBoxColumn.DataPropertyName = "experiencePoints";
            this.experiencePointsDataGridViewTextBoxColumn.HeaderText = "experiencePoints";
            this.experiencePointsDataGridViewTextBoxColumn.Name = "experiencePointsDataGridViewTextBoxColumn";
            this.experiencePointsDataGridViewTextBoxColumn.Width = 108;
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
            this.Load += new System.EventHandler(this.WorldManagerPlayerInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPlayers;
        private System.Windows.Forms.Button BtnLoadInformation;
        private System.Windows.Forms.Button BtnSaveInformation;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experiencePointsDataGridViewTextBoxColumn;
    }
}