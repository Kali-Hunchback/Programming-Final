using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace ProgrammingIIIFinal
{
    public partial class WorldManagerLogIn : Form
    {
        public WorldManagerLogIn()
        {
            InitializeComponent();
        }

        static string ComputeSHA256(string rawData) 
        {
            //initilize SHA256
            using (SHA256 sha256Hash = SHA256.Create()) 
            {
                //Set a new byte array to compute hash and set encoding before reading bytes to array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                //Convert byte array into string using Builder and .append
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) 
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                
                return builder.ToString().ToUpper();
            }
        }
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //If either of the text boxes on form are empty, then alert user of issue
            if (string.IsNullOrEmpty(TbUserName.Text) || string.IsNullOrEmpty(TbPassword.Text))
            {
                toolStripStatusLabel1.Text = "Please Enter Both your Username and Password Before Login!";
            }
            //If both text boxes are not empty, then create string. hash and match to hardcoded string
            else if (!string.IsNullOrEmpty(TbUserName.Text) && !string.IsNullOrEmpty(TbPassword.Text)) 
            {
                //Update user (unlikely user will ever see this message)
                toolStripStatusLabel1.Text = "Checking for log-in validity...";
                //Create log in string which will be converted to SHA256
                string checkLogIn = TbUserName.Text + "," + TbPassword.Text;
                //Compute hashing
                string hashedLogIn = ComputeSHA256(checkLogIn);
                //Equality check on SHA 256 for correct log-in information
                if (hashedLogIn.Equals("D6234DAF47D9A155CDF5FA8149928219DCFC442648B8007323C3675472EA4616"))
                {
                    toolStripStatusLabel1.Text = "Access Allowed";
                    WorldManagerMenu worldManagerMenu = new WorldManagerMenu(this);
                    this.Hide();
                    worldManagerMenu.ShowDialog();
                }
                else 
                {
                    toolStripStatusLabel1.Text = "Access Denied, Please Try Again";
                }
            }
        }
    }
}
