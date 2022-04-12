namespace Order_UI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostomerAdress = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCustomeTel = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderItem = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.butCalculate = new System.Windows.Forms.Button();
            this.butTotal = new System.Windows.Forms.Button();
            this.butSubTotal2 = new System.Windows.Forms.Button();
            this.butSubTotal1 = new System.Windows.Forms.Button();
            this.txtProduct2Price = new System.Windows.Forms.TextBox();
            this.txtProduct1Price = new System.Windows.Forms.TextBox();
            this.txtProduct2Count = new System.Windows.Forms.TextBox();
            this.txtProduct1Count = new System.Windows.Forms.TextBox();
            this.txtProduct2Name = new System.Windows.Forms.TextBox();
            this.txtProduct1Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.OrderItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCostomerAdress);
            this.groupBox1.Controls.Add(this.txtOrderDate);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.txtCustomeTel);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单";
            // 
            // txtCostomerAdress
            // 
            this.txtCostomerAdress.Location = new System.Drawing.Point(691, 32);
            this.txtCostomerAdress.Name = "txtCostomerAdress";
            this.txtCostomerAdress.Size = new System.Drawing.Size(269, 27);
            this.txtCostomerAdress.TabIndex = 9;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(392, 134);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(173, 27);
            this.txtOrderDate.TabIndex = 8;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(117, 134);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(168, 27);
            this.txtOrderID.TabIndex = 7;
            // 
            // txtCustomeTel
            // 
            this.txtCustomeTel.Location = new System.Drawing.Point(392, 32);
            this.txtCustomeTel.Name = "txtCustomeTel";
            this.txtCustomeTel.Size = new System.Drawing.Size(173, 27);
            this.txtCustomeTel.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(117, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(168, 27);
            this.txtCustomerName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "下单时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "订单编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "买家";
            // 
            // OrderItem
            // 
            this.OrderItem.Controls.Add(this.label10);
            this.OrderItem.Controls.Add(this.butCalculate);
            this.OrderItem.Controls.Add(this.butTotal);
            this.OrderItem.Controls.Add(this.butSubTotal2);
            this.OrderItem.Controls.Add(this.butSubTotal1);
            this.OrderItem.Controls.Add(this.txtProduct2Price);
            this.OrderItem.Controls.Add(this.txtProduct1Price);
            this.OrderItem.Controls.Add(this.txtProduct2Count);
            this.OrderItem.Controls.Add(this.txtProduct1Count);
            this.OrderItem.Controls.Add(this.txtProduct2Name);
            this.OrderItem.Controls.Add(this.txtProduct1Name);
            this.OrderItem.Controls.Add(this.label9);
            this.OrderItem.Controls.Add(this.Price);
            this.OrderItem.Controls.Add(this.label7);
            this.OrderItem.Controls.Add(this.txtProductName);
            this.OrderItem.Location = new System.Drawing.Point(47, 365);
            this.OrderItem.Name = "OrderItem";
            this.OrderItem.Size = new System.Drawing.Size(990, 364);
            this.OrderItem.TabIndex = 1;
            this.OrderItem.TabStop = false;
            this.OrderItem.Text = "订单项";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "总结";
            // 
            // butCalculate
            // 
            this.butCalculate.Location = new System.Drawing.Point(837, 317);
            this.butCalculate.Name = "butCalculate";
            this.butCalculate.Size = new System.Drawing.Size(81, 29);
            this.butCalculate.TabIndex = 18;
            this.butCalculate.Text = "计算";
            this.butCalculate.UseVisualStyleBackColor = true;
            this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
            // 
            // butTotal
            // 
            this.butTotal.Location = new System.Drawing.Point(837, 247);
            this.butTotal.Name = "butTotal";
            this.butTotal.Size = new System.Drawing.Size(81, 29);
            this.butTotal.TabIndex = 17;
            this.butTotal.UseVisualStyleBackColor = true;
            // 
            // butSubTotal2
            // 
            this.butSubTotal2.Location = new System.Drawing.Point(837, 196);
            this.butSubTotal2.Name = "butSubTotal2";
            this.butSubTotal2.Size = new System.Drawing.Size(81, 29);
            this.butSubTotal2.TabIndex = 16;
            this.butSubTotal2.UseVisualStyleBackColor = true;
            // 
            // butSubTotal1
            // 
            this.butSubTotal1.Location = new System.Drawing.Point(837, 147);
            this.butSubTotal1.Name = "butSubTotal1";
            this.butSubTotal1.Size = new System.Drawing.Size(81, 29);
            this.butSubTotal1.TabIndex = 15;
            this.butSubTotal1.UseVisualStyleBackColor = true;
            // 
            // txtProduct2Price
            // 
            this.txtProduct2Price.Location = new System.Drawing.Point(568, 217);
            this.txtProduct2Price.Name = "txtProduct2Price";
            this.txtProduct2Price.Size = new System.Drawing.Size(124, 27);
            this.txtProduct2Price.TabIndex = 14;
            // 
            // txtProduct1Price
            // 
            this.txtProduct1Price.Location = new System.Drawing.Point(568, 147);
            this.txtProduct1Price.Name = "txtProduct1Price";
            this.txtProduct1Price.Size = new System.Drawing.Size(124, 27);
            this.txtProduct1Price.TabIndex = 13;
            // 
            // txtProduct2Count
            // 
            this.txtProduct2Count.Location = new System.Drawing.Point(335, 217);
            this.txtProduct2Count.Name = "txtProduct2Count";
            this.txtProduct2Count.Size = new System.Drawing.Size(124, 27);
            this.txtProduct2Count.TabIndex = 12;
            // 
            // txtProduct1Count
            // 
            this.txtProduct1Count.Location = new System.Drawing.Point(336, 146);
            this.txtProduct1Count.Name = "txtProduct1Count";
            this.txtProduct1Count.Size = new System.Drawing.Size(124, 27);
            this.txtProduct1Count.TabIndex = 11;
            // 
            // txtProduct2Name
            // 
            this.txtProduct2Name.Location = new System.Drawing.Point(53, 217);
            this.txtProduct2Name.Name = "txtProduct2Name";
            this.txtProduct2Name.Size = new System.Drawing.Size(234, 27);
            this.txtProduct2Name.TabIndex = 10;
            // 
            // txtProduct1Name
            // 
            this.txtProduct1Name.Location = new System.Drawing.Point(53, 147);
            this.txtProduct1Name.Name = "txtProduct1Name";
            this.txtProduct1Name.Size = new System.Drawing.Size(234, 27);
            this.txtProduct1Name.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "小计";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(596, 107);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(39, 20);
            this.Price.TabIndex = 7;
            this.Price.Text = "单价";
            this.Price.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "数量";
            // 
            // txtProductName
            // 
            this.txtProductName.AutoSize = true;
            this.txtProductName.Location = new System.Drawing.Point(53, 107);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(69, 20);
            this.txtProductName.TabIndex = 5;
            this.txtProductName.Text = "商品名称";
            this.txtProductName.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 781);
            this.Controls.Add(this.OrderItem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OrderItem.ResumeLayout(false);
            this.OrderItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCostomerAdress;
        private TextBox txtOrderDate;
        private TextBox txtOrderID;
        private TextBox txtCustomeTel;
        private TextBox txtCustomerName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox OrderItem;
        private TextBox txtProduct2Price;
        private TextBox txtProduct1Price;
        private TextBox txtProduct2Count;
        private TextBox txtProduct1Count;
        private TextBox txtProduct2Name;
        private TextBox txtProduct1Name;
        private Label label9;
        private Label Price;
        private Label label7;
        private Label txtProductName;
        private Label label10;
        private Button butCalculate;
        private Button butTotal;
        private Button butSubTotal2;
        private Button butSubTotal1;
    }
}