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
    public partial class settingkalkulasi : Form
    {
        SqlDataAdapter da;
        DataTable table;
        public settingkalkulasi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                MessageBox.Show("Update failed" + ex);
            }
        }

        private void settingkalkulasi_Load(object sender, EventArgs e)
        {

            try
            {
                SqlCommand myCommand = new SqlCommand("select kode_customer,nama_customer,tipe_kalkulasi from iamcustomer", SQLclass.connection);
                da = new SqlDataAdapter(myCommand);
                table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);

                dataGridView1.AutoResizeColumns();

                // Configure the details DataGridView so that its columns automatically
                // adjust their widths when the data changes.
                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.AllCells;


                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }
    }
}
