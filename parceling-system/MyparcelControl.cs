using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parceling_system
{
    public partial class MyparcelControl : UserControl
    {
        public MyparcelControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyparcelControl_Load(object sender, EventArgs e)
        {
            MyparcelControl myparcel = new MyparcelControl();
        }

        
        private void productDetailspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pNextbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            LocationControl location = new LocationControl();
            this.Hide();
            this.Parent.Controls.Add(location);
        }
    }
}
