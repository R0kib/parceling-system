using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace parceling_system
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconBoxmenu_Click(object sender, EventArgs e)
        {
            if(slidepanel.Width == 200)
            {
                slidepanel.Width = 40;
                
            }
            else
            {
                slidepanel.Width = 200;
                
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btmMaxMin_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(0, 56, 85);
            btnExit.ForeColor = Color.White;
        }

        private void User_Load(object sender, EventArgs e)
        {
            productControl1.Hide();
            myparcelControl1.Hide();
            locationControl1.Hide();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            productControl1.Show();
            //hide others control
            myparcelControl1.Hide();
            locationControl1.Hide();
            orderControl1.Hide();
        }

        private void productButton_Enter(object sender, EventArgs e)
        {
            productButton.BackColor = Color.FromArgb(0, 37, 56);
        }

        private void productButton_Leave(object sender, EventArgs e)
        {
            productButton.BackColor = Color.FromArgb(0, 56, 85);
        }

        private void MyParcelButton_Enter(object sender, EventArgs e)
        {
            MyParcelButton.BackColor = Color.FromArgb(0, 37, 56);
        }

        private void MyParcelButton_Leave(object sender, EventArgs e)
        {
            MyParcelButton.BackColor = Color.FromArgb(0, 56, 85);
        }

        private void locationButton_Enter(object sender, EventArgs e)
        {
            locationButton.BackColor = Color.FromArgb(0, 37, 56);
        }

        private void locationButton_Leave(object sender, EventArgs e)
        {
            locationButton.BackColor = Color.FromArgb(0, 56, 85);
        }

        private void ordersButton_Enter(object sender, EventArgs e)
        {
            ordersButton.BackColor = Color.FromArgb(0, 37, 56);
        }

        private void ordersButton_Leave(object sender, EventArgs e)
        {
            ordersButton.BackColor = Color.FromArgb(0, 56, 85);
        }

        private void aboutButton_Enter(object sender, EventArgs e)
        {
            aboutButton.BackColor = Color.FromArgb(0, 37, 56);
        }

        private void aboutButton_Leave(object sender, EventArgs e)
        {
            aboutButton.BackColor = Color.FromArgb(0, 56, 85);
        }

        private void MyParcelButton_Click(object sender, EventArgs e)
        {
            myparcelControl1.Show();
            //hide other controls
            productControl1.Hide();
            locationControl1.Hide();
            orderControl1.Hide();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            locationControl1.Show();
            //hide other controls
            productControl1.Hide();
            myparcelControl1.Hide();
            orderControl1.Hide();
        }

        private void payButton_Enter(object sender, EventArgs e)
        {
            payButton.BackColor = Color.FromArgb(0, 37, 56);
        }

        private void payButton_Leave(object sender, EventArgs e)
        {
            payButton.BackColor = Color.FromArgb(0, 56, 85);
        }

        private void payButton_Click(object sender, EventArgs e)
        {

        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            orderControl1.Show();
            //hide other controls
            locationControl1.Hide();
            productControl1.Hide();
            myparcelControl1.Hide();
        }
    }
}
