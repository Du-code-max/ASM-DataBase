namespace ASM
{
	partial class FormEmployees
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
			this.label11 = new System.Windows.Forms.Label();
			this.cbEmployeeRights = new System.Windows.Forms.ComboBox();
			this.btLoadEe = new System.Windows.Forms.Button();
			this.btSearchEe = new System.Windows.Forms.Button();
			this.btDeleteEe = new System.Windows.Forms.Button();
			this.btEditEe = new System.Windows.Forms.Button();
			this.btAddEe = new System.Windows.Forms.Button();
			this.txtPassEe = new System.Windows.Forms.TextBox();
			this.txtUserEe = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.dataEe = new System.Windows.Forms.DataGridView();
			this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
			this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
			this.txtEmployeePhone = new System.Windows.Forms.TextBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataEe)).BeginInit();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(333, 107);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(113, 16);
			this.label11.TabIndex = 132;
			this.label11.Text = "Employee Rights:";
			// 
			// cbEmployeeRights
			// 
			this.cbEmployeeRights.FormattingEnabled = true;
			this.cbEmployeeRights.Items.AddRange(new object[] {
            "",
            "Administrator",
            "sales agent",
            "Warehouse staff"});
			this.cbEmployeeRights.Location = new System.Drawing.Point(475, 98);
			this.cbEmployeeRights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbEmployeeRights.Name = "cbEmployeeRights";
			this.cbEmployeeRights.Size = new System.Drawing.Size(160, 24);
			this.cbEmployeeRights.TabIndex = 131;
			// 
			// btLoadEe
			// 
			this.btLoadEe.Location = new System.Drawing.Point(211, 142);
			this.btLoadEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btLoadEe.Name = "btLoadEe";
			this.btLoadEe.Size = new System.Drawing.Size(75, 23);
			this.btLoadEe.TabIndex = 130;
			this.btLoadEe.Text = "Load";
			this.btLoadEe.UseVisualStyleBackColor = true;
			this.btLoadEe.Click += new System.EventHandler(this.btLoadEe_Click);
			// 
			// btSearchEe
			// 
			this.btSearchEe.Location = new System.Drawing.Point(653, 142);
			this.btSearchEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btSearchEe.Name = "btSearchEe";
			this.btSearchEe.Size = new System.Drawing.Size(75, 23);
			this.btSearchEe.TabIndex = 129;
			this.btSearchEe.Text = "Search";
			this.btSearchEe.UseVisualStyleBackColor = true;
			this.btSearchEe.Click += new System.EventHandler(this.btSearchEe_Click);
			// 
			// btDeleteEe
			// 
			this.btDeleteEe.Location = new System.Drawing.Point(532, 142);
			this.btDeleteEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btDeleteEe.Name = "btDeleteEe";
			this.btDeleteEe.Size = new System.Drawing.Size(75, 23);
			this.btDeleteEe.TabIndex = 128;
			this.btDeleteEe.Text = "Delete";
			this.btDeleteEe.UseVisualStyleBackColor = true;
			this.btDeleteEe.Click += new System.EventHandler(this.btDeleteEe_Click);
			// 
			// btEditEe
			// 
			this.btEditEe.Location = new System.Drawing.Point(424, 142);
			this.btEditEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btEditEe.Name = "btEditEe";
			this.btEditEe.Size = new System.Drawing.Size(75, 23);
			this.btEditEe.TabIndex = 127;
			this.btEditEe.Text = "Edit";
			this.btEditEe.UseVisualStyleBackColor = true;
			this.btEditEe.Click += new System.EventHandler(this.btEditEe_Click);
			// 
			// btAddEe
			// 
			this.btAddEe.Location = new System.Drawing.Point(323, 142);
			this.btAddEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btAddEe.Name = "btAddEe";
			this.btAddEe.Size = new System.Drawing.Size(75, 23);
			this.btAddEe.TabIndex = 126;
			this.btAddEe.Text = "Add";
			this.btAddEe.UseVisualStyleBackColor = true;
			this.btAddEe.Click += new System.EventHandler(this.btAddEe_Click);
			// 
			// txtPassEe
			// 
			this.txtPassEe.Location = new System.Drawing.Point(761, 66);
			this.txtPassEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassEe.Name = "txtPassEe";
			this.txtPassEe.Size = new System.Drawing.Size(151, 22);
			this.txtPassEe.TabIndex = 125;
			// 
			// txtUserEe
			// 
			this.txtUserEe.Location = new System.Drawing.Point(761, 27);
			this.txtUserEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUserEe.Name = "txtUserEe";
			this.txtUserEe.Size = new System.Drawing.Size(151, 22);
			this.txtUserEe.TabIndex = 124;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(676, 71);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(77, 16);
			this.label15.TabIndex = 123;
			this.label15.Text = "Pass Word:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(676, 33);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(79, 16);
			this.label14.TabIndex = 122;
			this.label14.Text = "User Name:";
			// 
			// dataEe
			// 
			this.dataEe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataEe.Location = new System.Drawing.Point(-35, 187);
			this.dataEe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataEe.Name = "dataEe";
			this.dataEe.RowHeadersWidth = 51;
			this.dataEe.RowTemplate.Height = 24;
			this.dataEe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataEe.Size = new System.Drawing.Size(1179, 324);
			this.dataEe.TabIndex = 121;
			this.dataEe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEe_CellContentClick);
			// 
			// txtEmployeeAddress
			// 
			this.txtEmployeeAddress.Location = new System.Drawing.Point(475, 66);
			this.txtEmployeeAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeeAddress.Name = "txtEmployeeAddress";
			this.txtEmployeeAddress.Size = new System.Drawing.Size(160, 22);
			this.txtEmployeeAddress.TabIndex = 120;
			// 
			// txtEmployeeEmail
			// 
			this.txtEmployeeEmail.Location = new System.Drawing.Point(475, 27);
			this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeeEmail.Name = "txtEmployeeEmail";
			this.txtEmployeeEmail.Size = new System.Drawing.Size(160, 22);
			this.txtEmployeeEmail.TabIndex = 119;
			// 
			// txtEmployeePhone
			// 
			this.txtEmployeePhone.Location = new System.Drawing.Point(155, 103);
			this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeePhone.Name = "txtEmployeePhone";
			this.txtEmployeePhone.Size = new System.Drawing.Size(132, 22);
			this.txtEmployeePhone.TabIndex = 118;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(155, 66);
			this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(132, 22);
			this.txtEmployeeName.TabIndex = 117;
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Location = new System.Drawing.Point(155, 27);
			this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(132, 22);
			this.txtEmployeeID.TabIndex = 116;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(333, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(126, 16);
			this.label10.TabIndex = 115;
			this.label10.Text = "Employee Address:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(333, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(109, 16);
			this.label9.TabIndex = 114;
			this.label9.Text = "Employee Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(35, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 16);
			this.label8.TabIndex = 113;
			this.label8.Text = "Employee Phone:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 16);
			this.label7.TabIndex = 112;
			this.label7.Text = "Employee Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 111;
			this.label6.Text = "Employee ID: ";
			// 
			// btExit
			// 
			this.btExit.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btExit.Location = new System.Drawing.Point(761, 142);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 133;
			this.btExit.Text = "EXIT";
			this.btExit.UseVisualStyleBackColor = false;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// FormEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1145, 538);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbEmployeeRights);
			this.Controls.Add(this.btLoadEe);
			this.Controls.Add(this.btSearchEe);
			this.Controls.Add(this.btDeleteEe);
			this.Controls.Add(this.btEditEe);
			this.Controls.Add(this.btAddEe);
			this.Controls.Add(this.txtPassEe);
			this.Controls.Add(this.txtUserEe);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dataEe);
			this.Controls.Add(this.txtEmployeeAddress);
			this.Controls.Add(this.txtEmployeeEmail);
			this.Controls.Add(this.txtEmployeePhone);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormEmployees";
			this.Text = "FormEmployees";
			this.Load += new System.EventHandler(this.FormEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataEe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbEmployeeRights;
		private System.Windows.Forms.Button btLoadEe;
		private System.Windows.Forms.Button btSearchEe;
		private System.Windows.Forms.Button btDeleteEe;
		private System.Windows.Forms.Button btEditEe;
		private System.Windows.Forms.Button btAddEe;
		private System.Windows.Forms.TextBox txtPassEe;
		private System.Windows.Forms.TextBox txtUserEe;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dataEe;
		private System.Windows.Forms.TextBox txtEmployeeAddress;
		private System.Windows.Forms.TextBox txtEmployeeEmail;
		private System.Windows.Forms.TextBox txtEmployeePhone;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.TextBox txtEmployeeID;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btExit;
	}
}