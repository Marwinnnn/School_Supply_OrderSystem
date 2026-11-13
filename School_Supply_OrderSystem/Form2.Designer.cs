namespace School_Supply_OrderSystem
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblClerk = new Label();
            lblsupply = new Label();
            lblUnitprice = new Label();
            lblQuantity = new Label();
            lblDiscount = new Label();
            lblOrderTotal = new Label();
            cmbPlan = new ComboBox();
            label7 = new Label();
            btnCompute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "CLERK: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "SUPPLY:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 168);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "UNIT PRICE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 229);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "QUANTITY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 287);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "DISOUNT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 346);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "ORDER TOTAL:";
            // 
            // lblClerk
            // 
            lblClerk.AutoSize = true;
            lblClerk.Location = new Point(172, 43);
            lblClerk.Name = "lblClerk";
            lblClerk.Size = new Size(58, 20);
            lblClerk.TabIndex = 0;
            lblClerk.Text = "CLERK: ";
            // 
            // lblsupply
            // 
            lblsupply.AutoSize = true;
            lblsupply.Location = new Point(172, 105);
            lblsupply.Name = "lblsupply";
            lblsupply.Size = new Size(60, 20);
            lblsupply.TabIndex = 1;
            lblsupply.Text = "SUPPLY:";
            // 
            // lblUnitprice
            // 
            lblUnitprice.AutoSize = true;
            lblUnitprice.Location = new Point(172, 168);
            lblUnitprice.Name = "lblUnitprice";
            lblUnitprice.Size = new Size(87, 20);
            lblUnitprice.TabIndex = 2;
            lblUnitprice.Text = "UNIT PRICE:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(172, 229);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(79, 20);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "QUANTITY";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(172, 287);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(75, 20);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "DISOUNT:";
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(172, 346);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(105, 20);
            lblOrderTotal.TabIndex = 5;
            lblOrderTotal.Text = "ORDER TOTAL:";
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Full Payment", "Split Payment", "Monthly Payment" });
            cmbPlan.Location = new Point(43, 421);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(202, 28);
            cmbPlan.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 398);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 5;
            label7.Text = "Payment Plan";
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(85, 473);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(105, 31);
            btnCompute.TabIndex = 7;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 575);
            Controls.Add(btnCompute);
            Controls.Add(cmbPlan);
            Controls.Add(lblOrderTotal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblDiscount);
            Controls.Add(label5);
            Controls.Add(lblQuantity);
            Controls.Add(label4);
            Controls.Add(lblUnitprice);
            Controls.Add(label3);
            Controls.Add(lblsupply);
            Controls.Add(label2);
            Controls.Add(lblClerk);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblClerk;
        private Label lblsupply;
        private Label lblUnitprice;
        private Label lblQuantity;
        private Label lblDiscount;
        private Label lblOrderTotal;
        private ComboBox cmbPlan;
        private Label label7;
        private Button btnCompute;
    }
}