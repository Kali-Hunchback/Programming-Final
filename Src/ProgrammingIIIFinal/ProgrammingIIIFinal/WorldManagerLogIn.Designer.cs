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
            this.LbUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
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
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Location = new System.Drawing.Point(95, 80);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(61, 13);
            this.LbUserName.TabIndex = 1;
            this.LbUserName.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
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
            // 
            // WorldManagerLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbUserName);
            this.Controls.Add(this.LblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorldManagerLogIn";
            this.Text = "World Manager Log-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnLogIn;
    }
}

