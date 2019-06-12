using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using DoorOpener.Static;
using System.Threading.Tasks;

namespace DoorOpener
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            init();
            Authenticate();
        }
        DataKeeper DataKeeper;
        Devices Devices;
        private bool bIsConnected = false;
        private int iMachineNumber = 1;
      
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

 
        void init()
        {
            DataKeeper = new DataKeeper();
            Devices = new Devices();

            var device = DataKeeper.device();
            if (device == null)
            {
                disConnected();
                return;
            }
            try
            {
                bIsConnected = axCZKEM1.Connect_Net(device.DeviceIp, Convert.ToInt32(device.DevicePort));
                iMachineNumber = 1;
                axCZKEM1.RegEvent(iMachineNumber, 65535);

                connected();
            }
            catch
            {
                MessageBox.Show("There is a small issue conntecting with device \n Please report Developer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 

        private void lblExit_Click(object sender, EventArgs e)
        {
            axCZKEM1.Disconnect();
            Application.Exit();
        }

        private async void lblDoorClose_Click(object sender, EventArgs e)
        {
            if (!openDoor())
                return;

            lblDoorClose.Visible = false;
            lblDoorOpen.Visible = true;

            await Task.Delay(4000);

            lblDoorOpen.Visible = false;
            lblDoorClose.Visible = true;

        }

        private void lblDoorOpen_Click(object sender, EventArgs e)
        {
            //lblDoorClose.Visible = true;
            //lblDoorOpen.Visible = false;
        }


        bool openDoor()
        {
            if (bIsConnected)
                axCZKEM1.ACUnlock(iMachineNumber, 9);
            else
                MessageBox.Show("The Device is Not Connected \n Please go to setup device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return bIsConnected;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
             
        }



        private void lblMove_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            using (IpForm ipForm=new IpForm())
            {
                if(ipForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
            

        }

        private void Authenticate()
        {
            using (AuthenticationForm ipForm = new AuthenticationForm())
            {
                if (ipForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        void connected()
        {
            lblConnected.Visible = true;
            lblDisconnected.Visible = false;
        }
        void disConnected()
        {
            lblConnected.Visible = false;
            lblDisconnected.Visible = true;
        }
    }
}
