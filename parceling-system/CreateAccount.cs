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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            if(firstName.Trim().Equals("First Name"))
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                panel2.BackColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            if (firstName.Trim().Equals("First Name")||firstName.Equals(""))
            {
                textBox2.Text = "First Name";
                textBox2.ForeColor = Color.Gray;
                panel2.BackColor = Color.Gray;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            //remove focus from the textbox
            this.ActiveControl = textBox1;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            string lastName = textBox3.Text;
            if (lastName.Trim().Equals("Last Name"))
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                panel3.BackColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string lastName = textBox3.Text;
            if (lastName.Trim().Equals("Last Name") || lastName.Equals(""))
            {
                textBox3.Text = "Last Name";
                textBox3.ForeColor = Color.Gray;
                panel3.BackColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            string userName = textBox4.Text;
            if (userName.Trim().Equals("Username"))
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                panel4.BackColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string Username = textBox4.Text;
            if (Username.Trim().Equals("Username") || Username.Equals(""))
            {
                textBox4.Text = "Username";
                textBox4.ForeColor = Color.Gray;
                panel4.BackColor = Color.Gray;
            }
        }
        //for email
        private void textBox5_Enter(object sender, EventArgs e)
        {
            string emailAddress = textBox5.Text;
            if (emailAddress.Trim().Equals("Email address"))
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                panel5.BackColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string emailAddress = textBox5.Text;
            if (emailAddress.Trim().Equals("Email address") || emailAddress.Equals(""))
            {
                textBox5.Text = "Email address";
                textBox5.ForeColor = Color.Gray;
                panel5.BackColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            string password = textBox6.Text;
            if (password.Trim().Equals("Password"))
            {
                textBox6.Text = "";
                textBox6.UseSystemPasswordChar = true;
                textBox6.ForeColor = Color.Black;
                panel6.BackColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string password = textBox6.Text;
            if (password.Trim().Equals("Password") || password.Equals(""))
            {
                textBox6.Text = "Password";
                textBox6.UseSystemPasswordChar = false;
                textBox6.ForeColor = Color.Gray;
                panel6.BackColor = Color.Gray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            string confirmPassword = textBox7.Text;
            if (confirmPassword.Trim().Equals("Confirm password"))
            {
                textBox7.Text = "";
                textBox7.UseSystemPasswordChar = true;
                textBox7.ForeColor = Color.Black;
                panel7.BackColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            string confirmPassword = textBox7.Text;
            if (confirmPassword.Trim().Equals("Confirm password") || confirmPassword.Equals(""))
            {
                textBox7.Text = "Confirm password";
                textBox7.UseSystemPasswordChar = false;
                textBox7.ForeColor = Color.Gray;
                panel7.BackColor = Color.Gray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            string nmber = textBox8.Text;
            if (nmber.Trim().Equals("Mobile number"))
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
                panel8.BackColor = Color.Black;
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            string nmber = textBox8.Text;
            if (nmber.Trim().Equals("Mobile number") || nmber.Equals(""))
            {
                textBox8.Text = "Email address";
                textBox8.ForeColor = Color.Gray;
                panel8.BackColor = Color.Gray;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.FromArgb(236, 240, 241);
            
        }

        
        MySqlConnection conect = new MySqlConnection("server=127.0.0.2;user id=root;port=3307;database=parcel_management_system");
        MySqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string insertQuery = "INSERT INTO `user`( `FirstName`, `LastName`, `userName`, `number`, `email`, `password`) VALUES (@firstName, @lastname, @userName, @number, @email, @pass)";
           cmd = new MySqlCommand(insertQuery, conect);
            //MySqlDataAdapter sda = new MySqlDataAdapter();
            /*cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@userName", MySqlDbType.VarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox8.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox6.Text;*/
            //cmd.Parameters.Add("", MySqlDbType.VarChar).Value = textBox2.Text;

            cmd.Parameters.AddWithValue("@firstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@userName", textBox4.Text);
            cmd.Parameters.AddWithValue("@number", textBox8.Text);
            cmd.Parameters.AddWithValue("@email", textBox5.Text);
            cmd.Parameters.AddWithValue("@pass", textBox6.Text);

            conect.Open();
            int rowcnt = cmd.ExecuteNonQuery();
            if (checktextbox() == false)
              {
                  if(textBox6.Text.Equals(textBox7.Text))
                  {

                      if (!userNameExist())
                      {

                          MessageBox.Show("Username Already Exist,Try again", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                      }
                      else
                      {
                            if ( rowcnt == 1)
                            {
                                MessageBox.Show("Account Created Successfully ", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }

                      }
                  }
                  else
                  {
                      MessageBox.Show("Password are not match,try again", "password error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                  }

              }
              else
              {
                  MessageBox.Show("At first insert your data", "Empty data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
              }
  




            //check textbox containts default value

            /*if (!checktextbox())
             {

                 if (textBox6.Text.Equals(textBox7.Text))
                 {
                     //check username is equal to others or not

                     if (userNameExist())
                     {
                         MessageBox.Show("Username Already Exist,Try again", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                     }
                     else
                     {
                         if (cmd.ExecuteNonQuery() == 1)
                         {
                             MessageBox.Show("Account Created Successfully ", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                        else
                        {
                            MessageBox.Show("Error", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                 }
                 else
                 {
                     MessageBox.Show("Password are not match,try again", "password error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                 }

             }
             else
             {
                 
             }*/

            conect.Close();

        }

        //cheak that username is already exist or not
        public Boolean userNameExist()
        {
            string username = textBox4.Text;
            string Userselect = "SELECT * FROM `user` WHERE `userName` = @usrn";
            cmd = new MySqlCommand(Userselect,conect);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            cmd.Parameters.Add("@usrn", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = cmd;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public Boolean checktextbox()
        {
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;
            string username = textBox4.Text;
            string nmber = textBox8.Text; 
            string email = textBox5.Text;
            string pass = textBox6.Text;
            
            if(firstname.Equals("First Name")||lastname.Equals("Last Name") || 
                username.Equals("Username")|| nmber.Equals("Mobile number") || email.Equals("Email address") ||
                pass.Equals("Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            adminLogin adminLogin = new adminLogin();
            adminLogin.Show();
        }

        
    }
}
