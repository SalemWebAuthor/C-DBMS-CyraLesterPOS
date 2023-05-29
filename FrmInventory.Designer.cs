namespace DBMS_Forms
{
    partial class FrmInventory
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
            this.searchbox_prodinv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.realneighborsDataSetUpdatedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realneighborsDataSetUpdated = new DBMS_Forms.realneighborsDataSetUpdated();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DBMS_Forms.realneighborsDataSetUpdatedTableAdapters.productTableAdapter();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.realneighborsDataSetUpdated1 = new DBMS_Forms.realneighborsDataSetUpdated();
            this.realneighborsDataSetUpdated1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producttypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdatedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT INVENTORY";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchbox_prodinv
            // 
            this.searchbox_prodinv.Location = new System.Drawing.Point(498, 253);
            this.searchbox_prodinv.Name = "searchbox_prodinv";
            this.searchbox_prodinv.Size = new System.Drawing.Size(155, 22);
            this.searchbox_prodinv.TabIndex = 1;
            this.searchbox_prodinv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchbox_prodinv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbox_prodinv_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search :";
            // 
            // dgv_products
            // 
            this.dgv_products.AutoGenerateColumns = false;
            this.dgv_products.ColumnHeadersHeight = 29;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn1,
            this.productnameDataGridViewTextBoxColumn1,
            this.productpriceDataGridViewTextBoxColumn1,
            this.producttypeDataGridViewTextBoxColumn1});
            this.dgv_products.DataSource = this.productBindingSource1;
            this.dgv_products.Location = new System.Drawing.Point(37, 292);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.Size = new System.Drawing.Size(616, 268);
            this.dgv_products.TabIndex = 0;
            this.dgv_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.realneighborsDataSetUpdatedBindingSource;
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.realneighborsDataSetUpdatedBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "product_price";
            this.productpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // producttypeDataGridViewTextBoxColumn
            // 
            this.producttypeDataGridViewTextBoxColumn.DataPropertyName = "product_type";
            this.producttypeDataGridViewTextBoxColumn.HeaderText = "product_type";
            this.producttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.producttypeDataGridViewTextBoxColumn.Name = "producttypeDataGridViewTextBoxColumn";
            this.producttypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(202, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Name:";
            // 
            // realneighborsDataSetUpdated1
            // 
            this.realneighborsDataSetUpdated1.DataSetName = "realneighborsDataSetUpdated";
            this.realneighborsDataSetUpdated1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realneighborsDataSetUpdated1BindingSource
            // 
            this.realneighborsDataSetUpdated1BindingSource.DataSource = this.realneighborsDataSetUpdated1;
            this.realneighborsDataSetUpdated1BindingSource.Position = 0;
            // 
            // productidDataGridViewTextBoxColumn1
            // 
            this.productidDataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn1.Name = "productidDataGridViewTextBoxColumn1";
            this.productidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productnameDataGridViewTextBoxColumn1
            // 
            this.productnameDataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn1.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn1.Name = "productnameDataGridViewTextBoxColumn1";
            this.productnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productpriceDataGridViewTextBoxColumn1
            // 
            this.productpriceDataGridViewTextBoxColumn1.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn1.HeaderText = "product_price";
            this.productpriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productpriceDataGridViewTextBoxColumn1.Name = "productpriceDataGridViewTextBoxColumn1";
            this.productpriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // producttypeDataGridViewTextBoxColumn1
            // 
            this.producttypeDataGridViewTextBoxColumn1.DataPropertyName = "product_type";
            this.producttypeDataGridViewTextBoxColumn1.HeaderText = "product_type";
            this.producttypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.producttypeDataGridViewTextBoxColumn1.Name = "producttypeDataGridViewTextBoxColumn1";
            this.producttypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMS_Forms.Properties.Resources.ricelogo;
            this.pictureBox1.Location = new System.Drawing.Point(456, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 195);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbox_prodinv);
            this.Controls.Add(this.label1);
            this.Name = "FrmInventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdatedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realneighborsDataSetUpdated1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox_prodinv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.BindingSource realneighborsDataSetUpdatedBindingSource;
        private realneighborsDataSetUpdated realneighborsDataSetUpdated;
        private System.Windows.Forms.BindingSource productBindingSource;
        private realneighborsDataSetUpdatedTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource realneighborsDataSetUpdated1BindingSource;
        private realneighborsDataSetUpdated realneighborsDataSetUpdated1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}