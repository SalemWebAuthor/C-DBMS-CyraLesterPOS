namespace DBMS_Forms
{
    partial class FrmCustomerList
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchbox_cust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cust = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realneighborsDataSetUpdatedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realneighborsDataSetUpdated = new DBMS_Forms.realneighborsDataSetUpdated();
            this.customerTableAdapter = new DBMS_Forms.realneighborsDataSetUpdatedTableAdapters.customerTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdatedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchbox_cust
            // 
            this.searchbox_cust.Location = new System.Drawing.Point(492, 66);
            this.searchbox_cust.Name = "searchbox_cust";
            this.searchbox_cust.Size = new System.Drawing.Size(155, 22);
            this.searchbox_cust.TabIndex = 9;
            this.searchbox_cust.TextChanged += new System.EventHandler(this.searchbox_cust_TextChanged);
            this.searchbox_cust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbox_cust_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "CUSTOMER LIST";
            // 
            // dgv_cust
            // 
            this.dgv_cust.AutoGenerateColumns = false;
            this.dgv_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn});
            this.dgv_cust.DataSource = this.customerBindingSource;
            this.dgv_cust.Location = new System.Drawing.Point(164, 143);
            this.dgv_cust.Name = "dgv_cust";
            this.dgv_cust.RowHeadersWidth = 51;
            this.dgv_cust.RowTemplate.Height = 24;
            this.dgv_cust.Size = new System.Drawing.Size(303, 258);
            this.dgv_cust.TabIndex = 12;
            this.dgv_cust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cust_CellContentClick);
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "cust_id";
            this.custidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.Width = 125;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "cust_name";
            this.custnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.realneighborsDataSetUpdatedBindingSource;
            // 
            // realneighborsDataSetUpdatedBindingSource
            // 
            this.realneighborsDataSetUpdatedBindingSource.DataSource = this.realneighborsDataSetUpdated;
            this.realneighborsDataSetUpdatedBindingSource.Position = 0;
            // 
            // realneighborsDataSetUpdated
            // 
            this.realneighborsDataSetUpdated.DataSetName = "realneighborsDataSetUpdated";
            this.realneighborsDataSetUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_cust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbox_cust);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomerList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdatedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchbox_cust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cust;
        private System.Windows.Forms.BindingSource realneighborsDataSetUpdatedBindingSource;
        private realneighborsDataSetUpdated realneighborsDataSetUpdated;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private realneighborsDataSetUpdatedTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}