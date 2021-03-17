using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace parceling_system
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {
             button2.Hide();
            button3.Hide();

            this.ActiveControl = textBoxUserName;
        }
        private void label3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            if (username.Trim().Equals("Username"))
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
                panel2.BackColor = Color.Black;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            if (username.Trim().Equals("Username") || username.Equals(""))
            {
                textBoxUserName.Text = "Username";
                textBoxUserName.ForeColor = Color.Gray;
                panel2.BackColor = Color.Gray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            string password = textBoxPass.Text;
            if (password.Trim().Equals("Password"))
            {
                textBoxPass.Text = "";
                textBoxPass.UseSystemPasswordChar = true;
                textBoxPass.ForeColor = Color.Black;
                panel3.BackColor = Color.Black;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            string password = textBoxPass.Text;
            if (password.Trim().Equals("Password")|| password.Equals(""))
            {
                textBoxPass.Text = "Password";
                textBoxPass.UseSystemPasswordChar = false;
                textBoxPass.ForeColor = Color.Gray;
                panel3.BackColor = Color.Gray;
            }
        }

       
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            label3.BackColor = Color.FromArgb(236, 240, 241);
        }

        //Sql Query

        MySqlConnection conect = new MySqlConnection("server=127.0.0.2;user id=root;port=3307;database=parcel_management_system");

        private MySqlCommand cmd;

        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPass.Text;

            DataTable td = new DataTable();
            MySqlDataAdapter SDA = new MySqlDataAdapter();

            string query = "SELECT * FROM `user` WHERE `userName` = @usern and `password` = @pass";
            cmd = new MySqlCommand(query, conect);
            
            
           
            cmd.Parameters.Add("@usern", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            SDA.SelectCommand = cmd;

            SDA.Fill(td);
           
            if (td.Rows.Count > 0)
            {
                button2.Show();
                button3.Show();
                
            }
            else
            {
                if (username.Trim().Equals("Username"))
                {
                    MessageBox.Show("Enter Your username", "empty username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals("Password"))
                {
                    MessageBox.Show("Enter Your password", "empty password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "wrong data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount account = new CreateAccount();
            account.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User use = new User();
            use.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delivaryman boy = new delivaryman();
            boy.Show();
        }
    }
}
