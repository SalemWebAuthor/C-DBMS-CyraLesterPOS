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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMS_Forms
{
    public partial class FrmCustomerList : Form
    {
        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\DBMS_Forms\DBMS_Forms\realneighbors.accdb");
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realneighborsDataSetUpdated.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.realneighborsDataSetUpdated.customer);
            customerBindingSource.DataSource = this.realneighborsDataSetUpdated.customer;

        }

        private void searchbox_cust_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_cust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbox_cust_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
                   + Application.StartupPath + @"\realneighbors.accdb");

                if (searchbox_cust.Text != " ")
                {
                    dgv_cust.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    OleDbDataAdapter adap = new OleDbDataAdapter();
                    DataSet ds = new DataSet();
                    DataView dv = new DataView();

                    string command = "SELECT * FROM [customer] WHERE cust_name LIKE '%" + searchbox_cust.Text + "%'";

                    conn.Open();
                    adap = new OleDbDataAdapter(command, conn);
                    adap.Fill(ds);
                    dv = new DataView(ds.Tables[0]);
                    dgv_cust.DataSource = dv;
                    conn.Close();
                }
                else if (searchbox_cust.Text == "")
                {
                    dgv_cust.Refresh();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    cmd.CommandText = "INSERT INTO [customer] (cust_name) VALUES ('" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    refresh();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerBindingSource.ResetBindings(false);
                }
            }
    }
        public void refresh()
        {
            string rfrsh = "SELECT * FROM [customer]";
            OleDbDataAdapter adap = new OleDbDataAdapter(rfrsh, cnn);
            DataSet ds = new DataSet();
            adap.Fill(ds, rfrsh);
            dgv_cust.DataSource = ds.Tables[0];
        }
    }
}
