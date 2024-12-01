using System.Windows.Forms;

namespace ASM
{
	partial class FormStatistical
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
			this.lbTotalProducts = new System.Windows.Forms.Label();
			this.btExit = new System.Windows.Forms.Button();
			this.btnCheckStock = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbProductStock = new System.Windows.Forms.Label();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblTotalProfit = new System.Windows.Forms.Label();
			this.lblTotalRevenue = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTotalProducts
			// 
			this.lbTotalProducts.AutoSize = true;
			this.lbTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTotalProducts.ForeColor = System.Drawing.Color.Cyan;
			this.lbTotalProducts.Location = new System.Drawing.Point(61, 185);
			this.lbTotalProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTotalProducts.Name = "lbTotalProducts";
			this.lbTotalProducts.Size = new System.Drawing.Size(0, 69);
			this.lbTotalProducts.TabIndex = 6;
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(638, 445);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 14;
			this.btExit.Text = "EXIT";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btnCheckStock
			// 
			this.btnCheckStock.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnCheckStock.Location = new System.Drawing.Point(246, 26);
			this.btnCheckStock.Name = "btnCheckStock";
			this.btnCheckStock.Size = new System.Drawing.Size(75, 35);
			this.btnCheckStock.TabIndex = 15;
			this.btnCheckStock.Text = "Check";
			this.btnCheckStock.UseVisualStyleBackColor = false;
			this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Statistic the number of products";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 22);
			this.textBox1.TabIndex = 17;
			// 
			// lbProductStock
			// 
			this.lbProductStock.AutoSize = true;
			this.lbProductStock.ForeColor = System.Drawing.Color.Red;
			this.lbProductStock.Location = new System.Drawing.Point(321, 26);
			this.lbProductStock.Name = "lbProductStock";
			this.lbProductStock.Size = new System.Drawing.Size(0, 16);
			this.lbProductStock.TabIndex = 18;
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Location = new System.Drawing.Point(14, 60);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
			this.dateTimePickerStart.TabIndex = 19;
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Location = new System.Drawing.Point(14, 132);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
			this.dateTimePickerEnd.TabIndex = 20;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCheckStock);
			this.panel1.Controls.Add(this.lbProductStock);
			this.panel1.Location = new System.Drawing.Point(47, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(543, 81);
			this.panel1.TabIndex = 21;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dateTimePickerEnd);
			this.panel2.Controls.Add(this.dateTimePickerStart);
			this.panel2.Location = new System.Drawing.Point(47, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(543, 167);
			this.panel2.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(296, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Statistic sales revenue by time (day, month, year)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(348, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 25);
			this.label8.TabIndex = 24;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.button1.Location = new System.Drawing.Point(256, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 48);
			this.button1.TabIndex = 23;
			this.button1.Text = "Check";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 16);
			this.label7.TabIndex = 22;
			this.label7.Text = "end";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 21;
			this.label6.Text = "start";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel3.Controls.Add(this.lblTotalProfit);
			this.panel3.Controls.Add(this.lblTotalRevenue);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.txtEmployeeID);
			this.panel3.Controls.Add(this.txtProductID);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new System.Drawing.Point(47, 352);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(543, 116);
			this.panel3.TabIndex = 24;
			// 
			// lblTotalProfit
			// 
			this.lblTotalProfit.AutoSize = true;
			this.lblTotalProfit.Location = new System.Drawing.Point(350, 70);
			this.lblTotalProfit.Name = "lblTotalProfit";
			this.lblTotalProfit.Size = new System.Drawing.Size(0, 16);
			this.lblTotalProfit.TabIndex = 25;
			// 
			// lblTotalRevenue
			// 
			this.lblTotalRevenue.AutoSize = true;
			this.lblTotalRevenue.Location = new System.Drawing.Point(350, 39);
			this.lblTotalRevenue.Name = "lblTotalRevenue";
			this.lblTotalRevenue.Size = new System.Drawing.Size(0, 16);
			this.lblTotalRevenue.TabIndex = 24;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 79);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 16);
			this.label11.TabIndex = 23;
			this.label11.Text = "Employee ID";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 45);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 16);
			this.label10.TabIndex = 22;
			this.label10.Text = "product ID";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Location = new System.Drawing.Point(104, 79);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
			this.txtEmployeeID.TabIndex = 21;
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(104, 39);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(100, 22);
			this.txtProductID.TabIndex = 20;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
			this.button2.Location = new System.Drawing.Point(249, 63);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 29);
			this.button2.TabIndex = 18;
			this.button2.Text = "Check";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(218, 16);
			this.label9.TabIndex = 17;
			this.label9.Text = "Statistic profit by product, employee";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "product ID";
			// 
			// FormStatistical
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 491);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.lbTotalProducts);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormStatistical";
			this.Text = "FormStatistical";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private Label lbTotalProducts;
		private Button btExit;
		private Button btnCheckStock;
		private Label label1;
		private TextBox textBox1;
		private Label lbProductStock;
		private DateTimePicker dateTimePickerStart;
		private DateTimePicker dateTimePickerEnd;
		private Panel panel1;
		private Panel panel2;
		private Label label7;
		private Label label6;
		private Button button1;
		private Label label8;
		private Panel panel3;
		private Label label11;
		private Label label10;
		private TextBox txtEmployeeID;
		private TextBox txtProductID;
		private Button button2;
		private Label label9;
		private Label lblTotalProfit;
		private Label lblTotalRevenue;
		private Label label2;
		private Label label3;
	}
}