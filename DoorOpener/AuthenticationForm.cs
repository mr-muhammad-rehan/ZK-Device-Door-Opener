using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorOpener
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "admin" && textPassword.Text == "123")
                this.Close();
            else
                MessageBox.Show("Please Enter Valid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
