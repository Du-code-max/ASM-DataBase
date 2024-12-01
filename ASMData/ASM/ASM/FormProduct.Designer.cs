namespace ASM
{
	partial class FormProduct
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
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.dataPr = new System.Windows.Forms.DataGridView();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btSearch = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.btEdit = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtSize = new System.Windows.Forms.TextBox();
			this.txtSellling = new System.Windows.Forms.TextBox();
			this.txtImport = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbPhoto = new System.Windows.Forms.ComboBox();
			this.Upload = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPr)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(381, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 16);
			this.label8.TabIndex = 62;
			this.label8.Text = "Product Photo:";
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(679, 15);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(200, 207);
			this.pictureBox.TabIndex = 61;
			this.pictureBox.TabStop = false;
			// 
			// dataPr
			// 
			this.dataPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPr.Location = new System.Drawing.Point(1, 228);
			this.dataPr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataPr.Name = "dataPr";
			this.dataPr.RowHeadersWidth = 51;
			this.dataPr.RowTemplate.Height = 24;
			this.dataPr.Size = new System.Drawing.Size(1336, 318);
			this.dataPr.TabIndex = 60;
			this.dataPr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPr_CellContentClick);
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(503, 94);
			this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(147, 22);
			this.txtStock.TabIndex = 59;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(381, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 16);
			this.label7.TabIndex = 58;
			this.label7.Text = "product Stock:";
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(437, 183);
			this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(75, 23);
			this.btSearch.TabIndex = 57;
			this.btSearch.Text = "Search";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(332, 183);
			this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(75, 23);
			this.btDelete.TabIndex = 56;
			this.btDelete.Text = "Delete";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
			// 
			// btEdit
			// 
			this.btEdit.Location = new System.Drawing.Point(232, 183);
			this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(75, 23);
			this.btEdit.TabIndex = 55;
			this.btEdit.Text = "Edit";
			this.btEdit.UseVisualStyleBackColor = true;
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(120, 183);
			this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 23);
			this.btAdd.TabIndex = 54;
			this.btAdd.Text = "Add";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(381, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 16);
			this.label6.TabIndex = 53;
			this.label6.Text = "Product Quantity:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(503, 54);
			this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(147, 22);
			this.txtQuantity.TabIndex = 52;
			// 
			// txtSize
			// 
			this.txtSize.Location = new System.Drawing.Point(503, 17);
			this.txtSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSize.Name = "txtSize";
			this.txtSize.Size = new System.Drawing.Size(147, 22);
			this.txtSize.TabIndex = 51;
			// 
			// txtSellling
			// 
			this.txtSellling.Location = new System.Drawing.Point(196, 130);
			this.txtSellling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSellling.Name = "txtSellling";
			this.txtSellling.Size = new System.Drawing.Size(143, 22);
			this.txtSellling.TabIndex = 50;
			// 
			// txtImport
			// 
			this.txtImport.Location = new System.Drawing.Point(196, 94);
			this.txtImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtImport.Name = "txtImport";
			this.txtImport.Size = new System.Drawing.Size(143, 22);
			this.txtImport.TabIndex = 49;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(196, 54);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(143, 22);
			this.txtName.TabIndex = 48;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(196, 17);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(143, 22);
			this.txtID.TabIndex = 47;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(381, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 16);
			this.label5.TabIndex = 46;
			this.label5.Text = "Product Size:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 16);
			this.label4.TabIndex = 45;
			this.label4.Text = "Product Selling Price:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 16);
			this.label3.TabIndex = 44;
			this.label3.Text = "Product Import price:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 43;
			this.label2.Text = "Product Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 42;
			this.label1.Text = "Product ID:";
			// 
			// cbPhoto
			// 
			this.cbPhoto.FormattingEnabled = true;
			this.cbPhoto.Location = new System.Drawing.Point(503, 132);
			this.cbPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.cbPhoto.Name = "cbPhoto";
			this.cbPhoto.Size = new System.Drawing.Size(147, 24);
			this.cbPhoto.TabIndex = 64;
			this.cbPhoto.SelectedIndexChanged += new System.EventHandler(this.cbPhoto_SelectedIndexChanged);
			// 
			// Upload
			// 
			this.Upload.Location = new System.Drawing.Point(550, 164);
			this.Upload.Margin = new System.Windows.Forms.Padding(4);
			this.Upload.Name = "Upload";
			this.Upload.Size = new System.Drawing.Size(100, 28);
			this.Upload.TabIndex = 65;
			this.Upload.Text = "Add photo";
			this.Upload.UseVisualStyleBackColor = true;
			this.Upload.Click += new System.EventHandler(this.Upload_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(910, 183);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 66;
			this.btExit.Text = "EXIT";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btLoad
			// 
			this.btLoad.Location = new System.Drawing.Point(28, 183);
			this.btLoad.Name = "btLoad";
			this.btLoad.Size = new System.Drawing.Size(75, 23);
			this.btLoad.TabIndex = 67;
			this.btLoad.Text = "Load";
			this.btLoad.UseVisualStyleBackColor = true;
			this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
			// 
			// FormProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1161, 549);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.Upload);
			this.Controls.Add(this.cbPhoto);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.dataPr);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btSearch);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btEdit);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtSize);
			this.Controls.Add(this.txtSellling);
			this.Controls.Add(this.txtImport);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormProduct";
			this.Text = "FormProduct";
			this.Load += new System.EventHandler(this.FormProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.DataGridView dataPr;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Button btEdit;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.TextBox txtSellling;
		private System.Windows.Forms.TextBox txtImport;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhoto;
        private System.Windows.Forms.Button Upload;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.Button btLoad;
	}
}