using DoorOpener.Static;
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
    public partial class IpForm : Form
    {
        DataKeeper datakeeper;
        public IpForm()
        {
            InitializeComponent();
            datakeeper = new DataKeeper();
        }

        private void IpForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (datakeeper.SaveDevice(textIp.Text, textPort.Text))
            {
                MessageBox.Show("Device has been Added Sucesfully\n Please Restart Application", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIp.Text = string.Empty;
                textPort.Text = string.Empty;
            }
            else
                MessageBox.Show("Error Adding Device", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void textIp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textIp_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(datakeeper.RemoveDevice())
            {
                MessageBox.Show("Device has been Removed Sucessfully \n Please Restart Application For effective use", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Device Associated ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }
 
    }
}
