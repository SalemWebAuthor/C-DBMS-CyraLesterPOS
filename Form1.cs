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
    public partial class frm_User : Form
    {
        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\DBMS_Forms\DBMS_Forms\realneighbors.accdb");
        public frm_User()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realneighborsDataSet2.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.realneighborsDataSet2.user);
            userBindingSource.DataSource = this.realneighborsDataSet2.user;

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            {
                try
                {
                    cnn.Open();
                    OleDbCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [user] (UserName, Password) VALUES (@UserName, @Password)";

                    cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    refresh();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userBindingSource.ResetBindings(false);
                }
            }

        }
        public void refresh()
        {
            string rfrsh = "SELECT * FROM [user]";
            OleDbDataAdapter adap = new OleDbDataAdapter(rfrsh, cnn);
            DataSet ds = new DataSet();
            adap.Fill(ds, rfrsh);
            dgv_users.DataSource = ds.Tables[0];
        }
    }
}
