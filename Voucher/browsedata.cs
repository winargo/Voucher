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
    public partial class browsedata : Form
    {
        SqlDataAdapter da;
        DataTable table;
        public browsedata()
        {
            InitializeComponent();
            browsedata main = this;
            main.Text = "Verify Customer Discount";
            main.CenterToScreen();
        }

        private void browsedata_Load(object sender, EventArgs e)
        {
            string myRequest = "SELECT * from iamcustomer";

            try
            {
                SqlCommand myCommand = new SqlCommand("select kode_customer,nama_customer,batas_omset,discount_nilai,disc_tambahan from iamcustomer", SQLclass.connection);
                da = new SqlDataAdapter(myCommand);
                table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(table);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed"+ex);
            }
        }
    }
}
