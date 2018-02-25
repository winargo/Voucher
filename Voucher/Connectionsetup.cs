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
using System.Security.Permissions;
using System.IO;


namespace Voucher
{
    [SerializableAttribute]
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
            try { 
                string readText = sw.ReadLine();
                string[] parts = readText.Split(' ');
                servername.Text = parts[0];
                dbname.Text = parts[1];
                sw.Close();
            }
            catch (Exception er){
                MessageBox.Show( er.ToString(), "Information");
            }

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
                    string createText = servername.Text.ToString() + " " + dbname.Text.ToString();
                    StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath), true, Encoding.ASCII);
                    sw.WriteLine(createText);
                    //      File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath), createText);
                    MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath), "Information");
                    //    File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath), FileAttributes.Normal);
                    sw.Close();
                    loginform b = new loginform();
                    this.Hide();
                    b.Show();
                }
                else {
                    
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Connection"+er,"Information");
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
