namespace DoorOpener
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoorClose = new System.Windows.Forms.Label();
            this.lblDoorOpen = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.Image = global::DoorOpener.Properties.Resources.not_connected;
            this.lblDisconnected.Location = new System.Drawing.Point(101, 47);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(100, 97);
            this.lblDisconnected.TabIndex = 9;
            this.lblDisconnected.Visible = false;
            // 
            // lblConnected
            // 
            this.lblConnected.Image = global::DoorOpener.Properties.Resources.connected;
            this.lblConnected.Location = new System.Drawing.Point(101, 47);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(100, 97);
            this.lblConnected.TabIndex = 9;
            this.lblConnected.Visible = false;
            // 
            // lblSetting
            // 
            this.lblSetting.Image = global::DoorOpener.Properties.Resources.ic_setting;
            this.lblSetting.Location = new System.Drawing.Point(205, 6);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(34, 27);
            this.lblSetting.TabIndex = 8;
            this.lblSetting.Click += new System.EventHandler(this.lblSetting_Click);
            // 
            // label3
            // 
            this.label3.Image = global::DoorOpener.Properties.Resources.ic_minimize;
            this.label3.Location = new System.Drawing.Point(245, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Image = global::DoorOpener.Properties.Resources.logo_png;
            this.label1.Location = new System.Drawing.Point(-19, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 81);
            this.label1.TabIndex = 4;
            // 
            // lblDoorClose
            // 
            this.lblDoorClose.Image = global::DoorOpener.Properties.Resources.door_close;
            this.lblDoorClose.Location = new System.Drawing.Point(3, 122);
            this.lblDoorClose.Name = "lblDoorClose";
            this.lblDoorClose.Size = new System.Drawing.Size(314, 399);
            this.lblDoorClose.TabIndex = 3;
            this.lblDoorClose.Click += new System.EventHandler(this.lblDoorClose_Click);
            // 
            // lblDoorOpen
            // 
            this.lblDoorOpen.Image = global::DoorOpener.Properties.Resources.door_open_;
            this.lblDoorOpen.Location = new System.Drawing.Point(2, 144);
            this.lblDoorOpen.Name = "lblDoorOpen";
            this.lblDoorOpen.Size = new System.Drawing.Size(305, 395);
            this.lblDoorOpen.TabIndex = 3;
            this.lblDoorOpen.Click += new System.EventHandler(this.lblDoorOpen_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Image = global::DoorOpener.Properties.Resources.exit;
            this.lblExit.Location = new System.Drawing.Point(283, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(34, 31);
            this.lblExit.TabIndex = 2;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 521);
            this.Controls.Add(this.lblDisconnected);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDoorClose);
            this.Controls.Add(this.lblDoorOpen);
            this.Controls.Add(this.lblExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AWJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblDoorOpen;
        private System.Windows.Forms.Label lblDoorClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblDisconnected;
    }
}

