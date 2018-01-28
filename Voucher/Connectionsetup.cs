using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Voucher
{
    public partial class Connectionsetup : Form
    {
        public Connectionsetup()
        {
            InitializeComponent();
            Connectionsetup main = this;
            main.Text = "Connection Setup";
            main.CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLclass c = new SQLclass(servername.Text.ToString(), dbname.Text.ToString());
            try
            {
                SQLclass.connection.Open();
                if (SQLclass.connection != null && SQLclass.connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected","Information");
                    mainmenu b = new mainmenu();
                    this.Hide();
                    b.Show();
                }
                else {
                    
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Connection","Information");
            }
            
            /*
            try
            {
                myConnection.Close();
            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
            }
            SqlCommand myCommand = new SqlCommand("Command String", myConnection);

            // - or -

            myCommand.Connection = myConnection;

            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
