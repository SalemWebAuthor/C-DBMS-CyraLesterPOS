namespace DBMS_Forms
{
    partial class FrmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.realneighborsDataSet3 = new DBMS_Forms.realneighborsDataSet3();
            this.salesreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesreportTableAdapter = new DBMS_Forms.realneighborsDataSet3TableAdapters.salesreportTableAdapter();
            this.realneighborsDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesreportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesreportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.realneighborsDataSet4 = new DBMS_Forms.realneighborsDataSet4();
            this.salesreportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.salesreportTableAdapter1 = new DBMS_Forms.realneighborsDataSet4TableAdapters.salesreportTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBoughtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES REPORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(139, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 210);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(35, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time of Transaction";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(35, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 22);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Products Ordered";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(247, 137);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 22);
            this.textBox8.TabIndex = 16;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // realneighborsDataSet3
            // 
            this.realneighborsDataSet3.DataSetName = "realneighborsDataSet3";
            this.realneighborsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesreportBindingSource
            // 
            this.salesreportBindingSource.DataMember = "salesreport";
            this.salesreportBindingSource.DataSource = this.realneighborsDataSet3;
            // 
            // salesreportTableAdapter
            // 
            this.salesreportTableAdapter.ClearBeforeFill = true;
            // 
            // realneighborsDataSet3BindingSource
            // 
            this.realneighborsDataSet3BindingSource.DataSource = this.realneighborsDataSet3;
            this.realneighborsDataSet3BindingSource.Position = 0;
            // 
            // salesreportBindingSource1
            // 
            this.salesreportBindingSource1.DataMember = "salesreport";
            this.salesreportBindingSource1.DataSource = this.realneighborsDataSet3BindingSource;
            // 
            // salesreportBindingSource2
            // 
            this.salesreportBindingSource2.DataMember = "salesreport";
            this.salesreportBindingSource2.DataSource = this.realneighborsDataSet3BindingSource;
            // 
            // dgv_reports
            // 
            this.dgv_reports.AutoGenerateColumns = false;
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.timeOfTransactionDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.productBoughtDataGridViewTextBoxColumn});
            this.dgv_reports.DataSource = this.salesreportBindingSource3;
            this.dgv_reports.Location = new System.Drawing.Point(79, 254);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.RowHeadersWidth = 51;
            this.dgv_reports.RowTemplate.Height = 24;
            this.dgv_reports.Size = new System.Drawing.Size(546, 184);
            this.dgv_reports.TabIndex = 2;
            // 
            // realneighborsDataSet4
            // 
            this.realneighborsDataSet4.DataSetName = "realneighborsDataSet4";
            this.realneighborsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesreportBindingSource3
            // 
            this.salesreportBindingSource3.DataMember = "salesreport";
            this.salesreportBindingSource3.DataSource = this.realneighborsDataSet4;
            // 
            // salesreportTableAdapter1
            // 
            this.salesreportTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeOfTransactionDataGridViewTextBoxColumn
            // 
            this.timeOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "TimeOfTransaction";
            this.timeOfTransactionDataGridViewTextBoxColumn.HeaderText = "TimeOfTransaction";
            this.timeOfTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeOfTransactionDataGridViewTextBoxColumn.Name = "timeOfTransactionDataGridViewTextBoxColumn";
            this.timeOfTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBoughtDataGridViewTextBoxColumn
            // 
            this.productBoughtDataGridViewTextBoxColumn.DataPropertyName = "ProductBought";
            this.productBoughtDataGridViewTextBoxColumn.HeaderText = "ProductBought";
            this.productBoughtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productBoughtDataGridViewTextBoxColumn.Name = "productBoughtDataGridViewTextBoxColumn";
            this.productBoughtDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.dgv_reports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Frm_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreportBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private realneighborsDataSet3 realneighborsDataSet3;
        private System.Windows.Forms.BindingSource salesreportBindingSource;
        private realneighborsDataSet3TableAdapters.salesreportTableAdapter salesreportTableAdapter;
        private System.Windows.Forms.BindingSource realneighborsDataSet3BindingSource;
        private System.Windows.Forms.BindingSource salesreportBindingSource1;
        private System.Windows.Forms.BindingSource salesreportBindingSource2;
        private System.Windows.Forms.DataGridView dgv_reports;
        private realneighborsDataSet4 realneighborsDataSet4;
        private System.Windows.Forms.BindingSource salesreportBindingSource3;
        private realneighborsDataSet4TableAdapters.salesreportTableAdapter salesreportTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBoughtDataGridViewTextBoxColumn;
    }
}