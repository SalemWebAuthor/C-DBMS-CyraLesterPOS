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
    public partial class FrmEmployees : Form
    {
        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\source\repos\DBMS_Forms\DBMS_Forms\realneighbors.accdb");
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void searchbox_emp_KeyPress(object sender, KeyPressEventArgs e)
        {

            OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
                + Application.StartupPath + @"\realneighbors.accdb");

            if (searchbox_emp.Text != " ")
            {
                dgv_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string command = "SELECT * FROM [employees] WHERE (first_name LIKE '%" + searchbox_emp.Text + "%') OR (last_name LIKE '%" + searchbox_emp.Text + "%') OR (employee_status LIKE '%" + searchbox_emp.Text + "%');";

                conn.Open();
                adap = new OleDbDataAdapter(command, conn);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dgv_employee.DataSource = dv;
                conn.Close();
            }
            else if (searchbox_emp.Text == "")
            {
                dgv_employee.Refresh();
            }
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realneighborsDataSetUpdated1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.realneighborsDataSetUpdated1.employees);
            employeesBindingSource.DataSource = this.realneighborsDataSetUpdated1.employees;

        }

        private void realneighborsDataSetUpdated1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "INSERT INTO [employees] (first_name, last_name, employee_status) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    refresh();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    employeesBindingSource.ResetBindings(false);
                }
            }
        }
        public void refresh()
        {
            string rfrsh = "SELECT * FROM [employees]";
            OleDbDataAdapter adap = new OleDbDataAdapter(rfrsh, cnn);
            DataSet ds = new DataSet();
            adap.Fill(ds, rfrsh);
            dgv_employee.DataSource = ds.Tables[0];
        }


    }
}
