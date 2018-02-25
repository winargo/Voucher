using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Voucher
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            loginform main = this;
            main.Text = "Login";
            main.CenterToScreen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                SqlDataReader myReader = null;
                String temp = password.Text.ToString();
                if (temp.Equals("")) {
                    temp = "";
                }
                SqlCommand myCommand = new SqlCommand("select * from xuser where user_id='" + username.Text.ToString() + "' and dbo.getpass(password)='" + temp + "'", SQLclass.connection);
                myReader = myCommand.ExecuteReader();
                int a = 0;
                while (myReader.Read())
                {
                    a++;

                   //Console.WriteLine(myReader["Column1"].ToString());
                   // Console.WriteLine(myReader["Column2"].ToString());
                }
                
                if (a > 0)
                {
                    
                    mainmenu menu = new mainmenu();
                    menu.Show();
                    this.Close();
                }
                else {
                   
                    password.Text = string.Empty;
                    MessageBox.Show("Username or Password Doesn't match", "Error");
                }
                myReader.Close();
            }
            catch {

            } 
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Application.Exit();
        }
    }
}
