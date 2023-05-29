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

    public partial class FrmReport : Form
    {
        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\DBMS_Forms\DBMS_Forms\realneighbors.accdb");
        public FrmReport()
        {
            InitializeComponent();
        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realneighborsDataSet4.salesreport' table. You can move, or remove it, as needed.
            this.salesreportTableAdapter1.Fill(this.realneighborsDataSet4.salesreport);
            // TODO: This line of code loads data into the 'realneighborsDataSet3.salesreport' table. You can move, or remove it, as needed.
            salesreportBindingSource.DataSource = this.realneighborsDataSet4.salesreport;

        }

        private void label1_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "INSERT INTO [salesreport] (TimeOfTransaction, Customer, AmountPaid,ProductBought) VALUES ('" + textBox5.Text + "', '" + textBox1.Text + "', '" + textBox4.Text + "₱','" + textBox8.Text + "')";
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    refresh();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salesreportBindingSource.ResetBindings(false);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void refresh()
        {
            string rfrsh = "SELECT * FROM [salesreport]";
            OleDbDataAdapter adap = new OleDbDataAdapter(rfrsh, cnn);
            DataSet ds = new DataSet();
            adap.Fill(ds, rfrsh);
            dgv_reports.DataSource = ds.Tables[0];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
