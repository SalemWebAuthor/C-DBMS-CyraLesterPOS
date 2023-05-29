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
    public partial class FrmInventory : Form
    {

        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\DBMS_Forms\DBMS_Forms\realneighbors.accdb");
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realneighborsDataSetUpdated.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.realneighborsDataSetUpdated.product);
            productBindingSource.DataSource = this.realneighborsDataSetUpdated.product;

        }

        private void searchbox_prodinv_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
               + Application.StartupPath + @"\realneighbors.accdb");
            */

            if (searchbox_prodinv.Text != "s")
            {
                dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string command = "SELECT * FROM [product] WHERE (product_name LIKE '%" + searchbox_prodinv.Text + "%') OR (product_price LIKE '%" + searchbox_prodinv.Text + "%') OR (product_type LIKE '%" + searchbox_prodinv.Text + "%');";

                cnn.Open();
                adap = new OleDbDataAdapter(command, cnn);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgv_products.DataSource = dv;
                cnn.Close();
            }
            else if (searchbox_prodinv.Text == "")
            {
                dgv_products.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    cmd.CommandText = "INSERT INTO [product] (product_name, product_price, product_type) VALUES ('" + textBox1.Text + "', '₱" + textBox2.Text + "', '" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    refresh();
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productBindingSource.ResetBindings(false);
                }
            }
        }

        public void refresh()
        {
            string rfrsh = "SELECT * FROM [product]";
            OleDbDataAdapter adap = new OleDbDataAdapter(rfrsh, cnn);
            DataSet ds = new DataSet();
            adap.Fill(ds, rfrsh);
            dgv_products.DataSource = ds.Tables[0];
        }
    }
}
