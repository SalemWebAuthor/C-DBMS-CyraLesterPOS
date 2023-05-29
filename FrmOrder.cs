using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Forms
{
    public partial class FrmOrder : Form
    {

        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\DBMS_Forms\DBMS_Forms\realneighbors.accdb");

        public FrmOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    cnn.Open();
                    OleDbCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [Orders] (CustomerName,ProductPurchased, TotalPrice) VALUES ('" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox3.Text + "₱')";
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    refresh();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ordersBindingSource.ResetBindings(false);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realneighborsDataSet2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.realneighborsDataSet2.Orders);
            ordersBindingSource.DataSource = this.realneighborsDataSet2.Orders;

        }
        public void refresh()
        {
            string rfrsh = "SELECT * FROM [Orders]";
            OleDbDataAdapter adap = new OleDbDataAdapter(rfrsh, cnn);
            DataSet ds = new DataSet();
            adap.Fill(ds, rfrsh);
            dgv_orders.DataSource = ds.Tables[0];
        }
    }
}

