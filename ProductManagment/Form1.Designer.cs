namespace ProductManagment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.disc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(314, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(349, 39);
            this.id.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(314, 581);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 46);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // time
            // 
            this.time.CustomFormat = "yyyy-MM-dd";
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(314, 488);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(437, 39);
            this.time.TabIndex = 3;
            this.time.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(314, 411);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(222, 40);
            this.cboCategory.TabIndex = 4;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "ProductId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discontinued";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(314, 285);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(83, 39);
            this.quantity.TabIndex = 11;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(314, 223);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(136, 39);
            this.price.TabIndex = 12;
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(314, 166);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(136, 39);
            this.unit.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(314, 106);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(349, 39);
            this.name.TabIndex = 14;
            // 
            // disc
            // 
            this.disc.Location = new System.Drawing.Point(314, 346);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(83, 39);
            this.disc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "CreateDate";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(807, 581);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 46);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(554, 581);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(150, 46);
            this.edit.TabIndex = 20;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idV,
            this.priceV,
            this.nameV,
            this.cateV,
            this.unitV,
            this.quantityV,
            this.discon,
            this.timeV});
            this.dgvProduct.Location = new System.Drawing.Point(12, 655);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 82;
            this.dgvProduct.RowTemplate.Height = 41;
            this.dgvProduct.Size = new System.Drawing.Size(1690, 304);
            this.dgvProduct.TabIndex = 21;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_cellContent);
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idV
            // 
            this.idV.DataPropertyName = "ProductId";
            this.idV.HeaderText = "ProductId";
            this.idV.MinimumWidth = 10;
            this.idV.Name = "idV";
            this.idV.Width = 200;
            // 
            // priceV
            // 
            this.priceV.DataPropertyName = "Price";
            this.priceV.HeaderText = "Price";
            this.priceV.MinimumWidth = 10;
            this.priceV.Name = "priceV";
            this.priceV.Width = 200;
            // 
            // nameV
            // 
            this.nameV.DataPropertyName = "ProductName";
            this.nameV.HeaderText = "ProductName";
            this.nameV.MinimumWidth = 10;
            this.nameV.Name = "nameV";
            this.nameV.Width = 200;
            // 
            // cateV
            // 
            this.cateV.DataPropertyName = "CategoryId";
            this.cateV.HeaderText = "CategoryId";
            this.cateV.MinimumWidth = 10;
            this.cateV.Name = "cateV";
            this.cateV.Width = 200;
            // 
            // unitV
            // 
            this.unitV.DataPropertyName = "Unit";
            this.unitV.HeaderText = "Unit";
            this.unitV.MinimumWidth = 10;
            this.unitV.Name = "unitV";
            this.unitV.Width = 200;
            // 
            // quantityV
            // 
            this.quantityV.DataPropertyName = "Quantity";
            this.quantityV.HeaderText = "Quantity";
            this.quantityV.MinimumWidth = 10;
            this.quantityV.Name = "quantityV";
            this.quantityV.Width = 200;
            // 
            // discon
            // 
            this.discon.DataPropertyName = "Discontinued";
            this.discon.HeaderText = "Discontinued";
            this.discon.MinimumWidth = 10;
            this.discon.Name = "discon";
            this.discon.Width = 200;
            // 
            // timeV
            // 
            this.timeV.DataPropertyName = "CreateDate";
            this.timeV.HeaderText = "CreateDate";
            this.timeV.MinimumWidth = 10;
            this.timeV.Name = "timeV";
            this.timeV.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 971);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.time);
            this.Controls.Add(this.add);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox disc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateV;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discon;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeV;
    }
}
