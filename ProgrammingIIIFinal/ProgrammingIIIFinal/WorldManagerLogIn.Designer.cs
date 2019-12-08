namespace ProgrammingIIIFinal
{
    partial class WorldManagerLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldManagerLogIn));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.SSLogIn = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(56, 9);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(250, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "World Manager";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(95, 80);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(61, 13);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Username: ";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(95, 137);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(98, 96);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(167, 20);
            this.TbUserName.TabIndex = 3;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(98, 153);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(167, 20);
            this.TbPassword.TabIndex = 4;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.Location = new System.Drawing.Point(63, 216);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(234, 137);
            this.BtnLogIn.TabIndex = 5;
            this.BtnLogIn.Text = "Adventure Awaits!";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // SSLogIn
            // 
            this.SSLogIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SSLogIn.Location = new System.Drawing.Point(0, 388);
            this.SSLogIn.Name = "SSLogIn";
            this.SSLogIn.Size = new System.Drawing.Size(377, 22);
            this.SSLogIn.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(271, 17);
            this.toolStripStatusLabel1.Text = "Welcome, Please Enter Your Information to Log-In";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorldManagerLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.SSLogIn);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorldManagerLogIn";
            this.Text = "World Manager Log-In";
            this.SSLogIn.ResumeLayout(false);
            this.SSLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.StatusStrip SSLogIn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

