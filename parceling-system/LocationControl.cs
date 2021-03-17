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
    public partial class LocationControl : UserControl
    {
        public LocationControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            orderControl order = new orderControl();
            this.Hide();
            this.Parent.Controls.Add(order);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendbutton_Click(object sender, EventArgs e)
        {

        }

        private void LocationControl_Load(object sender, EventArgs e)
        {
            LocationControl location = new LocationControl();

        }
    }
}
