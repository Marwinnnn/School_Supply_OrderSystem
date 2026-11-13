namespace School_Supply_OrderSystem
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
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            cmbsupply = new ComboBox();
            chkDsicount = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddOrder = new Button();
            btnView = new Button();
            dvgTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgTable).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(131, 27);
            txtName.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(49, 154);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(131, 27);
            txtQuantity.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(568, 52);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(131, 27);
            txtPrice.TabIndex = 2;
            // 
            // cmbsupply
            // 
            cmbsupply.FormattingEnabled = true;
            cmbsupply.Items.AddRange(new object[] { "Backpack - 950", "Scientific Calculator - 1,250", "Art Kit - 680", "Notebook Bundle - 300", "Study Lamp - 750" });
            cmbsupply.Location = new Point(252, 48);
            cmbsupply.Name = "cmbsupply";
            cmbsupply.Size = new Size(188, 28);
            cmbsupply.TabIndex = 3;
            cmbsupply.SelectedIndexChanged += cmbsupply_SelectedIndexChanged;
            // 
            // chkDsicount
            // 
            chkDsicount.AutoSize = true;
            chkDsicount.Location = new Point(262, 154);
            chkDsicount.Name = "chkDsicount";
            chkDsicount.Size = new Size(121, 24);
            chkDsicount.TabIndex = 4;
            chkDsicount.Text = "10% Discount";
            chkDsicount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 5;
            label1.Text = "Clerk Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 131);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 25);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 7;
            label3.Text = "Supply Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 25);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Unit Price";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(491, 143);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(97, 41);
            btnAddOrder.TabIndex = 9;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(619, 143);
            btnView.Name = "btnView";
            btnView.Size = new Size(119, 41);
            btnView.TabIndex = 10;
            btnView.Text = "View Summary";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dvgTable
            // 
            dvgTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTable.BorderStyle = BorderStyle.Fixed3D;
            dvgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTable.Location = new Point(1, 254);
            dvgTable.MultiSelect = false;
            dvgTable.Name = "dvgTable";
            dvgTable.ReadOnly = true;
            dvgTable.RowHeadersVisible = false;
            dvgTable.RowHeadersWidth = 51;
            dvgTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgTable.Size = new Size(773, 247);
            dvgTable.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 504);
            Controls.Add(dvgTable);
            Controls.Add(btnView);
            Controls.Add(btnAddOrder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkDsicount);
            Controls.Add(cmbsupply);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cmbsupply;
        private CheckBox chkDsicount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddOrder;
        private Button btnView;
        public DataGridView dvgTable;
    }
}
