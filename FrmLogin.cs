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
using System.Xml.Linq;

namespace DBMS_Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            string query_1;
            string query_2;
            OleDbConnection cnn;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\source\\repos\\DBMS_Forms\\DBMS_Forms\\realneighbors.accdb";
            cnn = new OleDbConnection(connectionString);
            cnn.Open();

            query_1 = "SELECT * FROM [user] WHERE UserName = '" + textBox1.Text + "'";
            OleDbCommand command1 = new OleDbCommand(query_1, cnn);
            OleDbDataReader dr1 = command1.ExecuteReader();

            query_2 = "SELECT * FROM [user] WHERE Password = '" + textBox2.Text + "'";
            OleDbCommand command2 = new OleDbCommand(query_2, cnn);
            OleDbDataReader dr2 = command2.ExecuteReader();



            try
            {
                if (dr1.Read() == true && dr2.Read() == true)
                {
                    MessageBox.Show("Login Successful");
                    FrmHomepage form1 = new FrmHomepage();
                    form1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string connectionString = null;
            OleDbConnection cnn;
            connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\user\\source\\repos\\DBMS_Forms\\DBMS_Forms\realneighbors.accdb";
            cnn = new OleDbConnection(connectionString);
            cnn.Open();

            try
            {
                MessageBox.Show("Connection is Functioning!");
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Connection Failed!");
            }
        }
    }
}
