namespace ProgrammingIIIFinal
{
    partial class WorldManagerSpellCompendium
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
            this.LbSpellBox = new System.Windows.Forms.ListBox();
            this.LblList = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbLevel = new System.Windows.Forms.TextBox();
            this.TbComponents = new System.Windows.Forms.TextBox();
            this.TbSchool = new System.Windows.Forms.TextBox();
            this.TbTime = new System.Windows.Forms.TextBox();
            this.TbRange = new System.Windows.Forms.TextBox();
            this.TbAvailableClass = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.LblSchool = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblRange = new System.Windows.Forms.Label();
            this.LblComponents = new System.Windows.Forms.Label();
            this.LblClasses = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.TbDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbSpellBox
            // 
            this.LbSpellBox.FormattingEnabled = true;
            this.LbSpellBox.Location = new System.Drawing.Point(13, 22);
            this.LbSpellBox.Name = "LbSpellBox";
            this.LbSpellBox.Size = new System.Drawing.Size(291, 420);
            this.LbSpellBox.TabIndex = 0;
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Location = new System.Drawing.Point(13, 3);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(49, 13);
            this.LblList.TabIndex = 1;
            this.LblList.Text = "Spell List";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(351, 22);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 20);
            this.TbName.TabIndex = 2;
            // 
            // TbLevel
            // 
            this.TbLevel.Location = new System.Drawing.Point(476, 22);
            this.TbLevel.Name = "TbLevel";
            this.TbLevel.Size = new System.Drawing.Size(100, 20);
            this.TbLevel.TabIndex = 3;
            // 
            // TbComponents
            // 
            this.TbComponents.Location = new System.Drawing.Point(351, 155);
            this.TbComponents.Multiline = true;
            this.TbComponents.Name = "TbComponents";
            this.TbComponents.Size = new System.Drawing.Size(225, 79);
            this.TbComponents.TabIndex = 4;
            // 
            // TbSchool
            // 
            this.TbSchool.Location = new System.Drawing.Point(351, 64);
            this.TbSchool.Name = "TbSchool";
            this.TbSchool.Size = new System.Drawing.Size(100, 20);
            this.TbSchool.TabIndex = 5;
            // 
            // TbTime
            // 
            this.TbTime.Location = new System.Drawing.Point(476, 64);
            this.TbTime.Name = "TbTime";
            this.TbTime.Size = new System.Drawing.Size(100, 20);
            this.TbTime.TabIndex = 6;
            // 
            // TbRange
            // 
            this.TbRange.Location = new System.Drawing.Point(415, 109);
            this.TbRange.Name = "TbRange";
            this.TbRange.Size = new System.Drawing.Size(100, 20);
            this.TbRange.TabIndex = 7;
            // 
            // TbAvailableClass
            // 
            this.TbAvailableClass.Location = new System.Drawing.Point(476, 262);
            this.TbAvailableClass.Multiline = true;
            this.TbAvailableClass.Name = "TbAvailableClass";
            this.TbAvailableClass.Size = new System.Drawing.Size(240, 41);
            this.TbAvailableClass.TabIndex = 7;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(351, 309);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(437, 129);
            this.TbDescription.TabIndex = 8;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(348, 3);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(61, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Spell Name";
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Location = new System.Drawing.Point(473, 3);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(59, 13);
            this.LblLevel.TabIndex = 1;
            this.LblLevel.Text = "Spell Level";
            // 
            // LblSchool
            // 
            this.LblSchool.AutoSize = true;
            this.LblSchool.Location = new System.Drawing.Point(348, 48);
            this.LblSchool.Name = "LblSchool";
            this.LblSchool.Size = new System.Drawing.Size(66, 13);
            this.LblSchool.TabIndex = 1;
            this.LblSchool.Text = "Spell School";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(473, 48);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(65, 13);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "Time to cast";
            // 
            // LblRange
            // 
            this.LblRange.AutoSize = true;
            this.LblRange.Location = new System.Drawing.Point(416, 93);
            this.LblRange.Name = "LblRange";
            this.LblRange.Size = new System.Drawing.Size(65, 13);
            this.LblRange.TabIndex = 1;
            this.LblRange.Text = "Spell Range";
            // 
            // LblComponents
            // 
            this.LblComponents.AutoSize = true;
            this.LblComponents.Location = new System.Drawing.Point(348, 139);
            this.LblComponents.Name = "LblComponents";
            this.LblComponents.Size = new System.Drawing.Size(92, 13);
            this.LblComponents.TabIndex = 1;
            this.LblComponents.Text = "Spell Components";
            // 
            // LblClasses
            // 
            this.LblClasses.AutoSize = true;
            this.LblClasses.Location = new System.Drawing.Point(473, 246);
            this.LblClasses.Name = "LblClasses";
            this.LblClasses.Size = new System.Drawing.Size(150, 13);
            this.LblClasses.TabIndex = 1;
            this.LblClasses.Text = "Classes Spell Can Be Used By";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(348, 293);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(86, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "Spell Description";
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Location = new System.Drawing.Point(348, 246);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(73, 13);
            this.LblDuration.TabIndex = 1;
            this.LblDuration.Text = "Spell Duration";
            // 
            // TbDuration
            // 
            this.TbDuration.Location = new System.Drawing.Point(351, 262);
            this.TbDuration.Name = "TbDuration";
            this.TbDuration.Size = new System.Drawing.Size(100, 20);
            this.TbDuration.TabIndex = 7;
            // 
            // WorldManagerSpellCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.TbDuration);
            this.Controls.Add(this.TbAvailableClass);
            this.Controls.Add(this.TbRange);
            this.Controls.Add(this.TbTime);
            this.Controls.Add(this.TbSchool);
            this.Controls.Add(this.TbComponents);
            this.Controls.Add(this.TbLevel);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblClasses);
            this.Controls.Add(this.LblComponents);
            this.Controls.Add(this.LblRange);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblSchool);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblList);
            this.Controls.Add(this.LbSpellBox);
            this.Name = "WorldManagerSpellCompendium";
            this.Text = "WorldManagerSpellCompendium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbSpellBox;
        private System.Windows.Forms.Label LblList;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbLevel;
        private System.Windows.Forms.TextBox TbComponents;
        private System.Windows.Forms.TextBox TbSchool;
        private System.Windows.Forms.TextBox TbTime;
        private System.Windows.Forms.TextBox TbRange;
        private System.Windows.Forms.TextBox TbAvailableClass;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.Label LblSchool;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblRange;
        private System.Windows.Forms.Label LblComponents;
        private System.Windows.Forms.Label LblClasses;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.TextBox TbDuration;
    }
}