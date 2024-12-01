using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Configuration;
using System.Drawing;


namespace ASM
{
    public partial class FormProduct : Form
    {
		private string Employeerights;
		string connectString = @"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        string imageDirectory = ConfigurationSettings.AppSettings["ImageDirectory"];
        string applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private string selectedImagePath;

        public FormProduct(string EmployeeRights)
        {
			Employeerights = EmployeeRights;
			InitializeComponent();
        }

        private void LoadProducts()
        {
            con = new SqlConnection(connectString);
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT TOP (1000) [ProductID], [ProductName], [ProductImportPrice], [ProductSellingPrice], [ProductSize], [ProductQuantity], [ProductStock], [ProductPhoto] FROM [ASMDATA].[dbo].[Products]", con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear();
                adt.Fill(dt);
                dataPr.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

      

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            string fullPath = Path.Combine(applicationDirectory, imageDirectory);
            LoadImageFiles(fullPath);
        }

        private void dataPr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dataPr.Rows[e.RowIndex];
                txtID.Text = row.Cells["ProductID"].Value.ToString();
                txtName.Text = row.Cells["ProductName"].Value.ToString();
                txtImport.Text = row.Cells["ProductImportPrice"].Value.ToString();
                txtSellling.Text = row.Cells["ProductSellingPrice"].Value.ToString();
                txtSize.Text = row.Cells["ProductSize"].Value.ToString();
                txtQuantity.Text = row.Cells["ProductQuantity"].Value.ToString();
                txtStock.Text = row.Cells["ProductStock"].Value.ToString();

                string selectedImageName = row.Cells["ProductPhoto"].Value.ToString();

                if (!string.IsNullOrEmpty(selectedImageName))
                {
                    cbPhoto.SelectedItem = selectedImageName;
                }
            }
        }
        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            con = new SqlConnection(connectString);
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", con);
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.ExecuteNonQuery();
				cmd.ExecuteNonQuery();
				LoadProducts();
				txtID.Clear();
				txtName.Clear();
				txtImport.Clear();
				txtSellling.Clear();
				txtSize.Clear();
				txtQuantity.Clear();
				txtStock.Clear();
				MessageBox.Show("Product deleted successfully.");
                LoadProducts(); 
				pictureBox.Image.Dispose(); 
				pictureBox.Image = null;
			}
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btEdit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            string selectedImageName = cbPhoto.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedImageName))
            {
                MessageBox.Show("Please select an image from the combo box.");
                return;
            }

            con = new SqlConnection(connectString);
            try
            {
                con.Open();

                cmd = new SqlCommand("UPDATE Products SET ProductName = @ProductName, ProductImportPrice = @ProductImportPrice, ProductSellingPrice = @ProductSellingPrice, ProductSize = @ProductSize, ProductQuantity = @ProductQuantity, ProductStock = @ProductStock, ProductPhoto = @ProductPhoto WHERE ProductID = @ProductID", con);

            
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtName.Text);
                cmd.Parameters.AddWithValue("@ProductImportPrice", txtImport.Text);
                cmd.Parameters.AddWithValue("@ProductSellingPrice", txtSellling.Text);
                cmd.Parameters.AddWithValue("@ProductSize", txtSize.Text);
                cmd.Parameters.AddWithValue("@ProductQuantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@ProductStock", txtStock.Text);
                cmd.Parameters.AddWithValue("@ProductPhoto", selectedImageName);

             
                cmd.ExecuteNonQuery();
				cmd.ExecuteNonQuery();
				LoadProducts();
				txtID.Clear();
				txtName.Clear();
				txtImport.Clear();
				txtSellling.Clear();
				txtSize.Clear();
				txtQuantity.Clear();
				txtStock.Clear();
				cbPhoto.SelectedIndex = -1;
				MessageBox.Show("Product updated successfully.");
				pictureBox.Image.Dispose(); 
				pictureBox.Image = null;

				LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void btAdd_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);
            try
            {
                con.Open();

                string selectedImageName = cbPhoto.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedImageName))
                {
                    MessageBox.Show("Please select an image from the combo box.");
                    return; 
                }
                cmd = new SqlCommand("INSERT INTO Products (ProductName, ProductImportPrice, ProductSellingPrice, ProductSize, ProductQuantity, ProductStock, ProductPhoto) " +
                                     "VALUES (@ProductName, @ProductImportPrice, @ProductSellingPrice, @ProductSize, @ProductQuantity, @ProductStock, @ProductPhoto)", con);

                cmd.Parameters.AddWithValue("@ProductName", txtName.Text);
                cmd.Parameters.AddWithValue("@ProductImportPrice", txtImport.Text);
                cmd.Parameters.AddWithValue("@ProductSellingPrice", txtSellling.Text);
                cmd.Parameters.AddWithValue("@ProductSize", txtSize.Text);
                cmd.Parameters.AddWithValue("@ProductQuantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@ProductStock", txtStock.Text);
                cmd.Parameters.AddWithValue("@ProductPhoto", selectedImageName);
                cmd.ExecuteNonQuery();
				LoadProducts();
				txtID.Clear();
				txtName.Clear();
				txtImport.Clear();
				txtSellling.Clear();
				txtSize.Clear();
				txtQuantity.Clear();
				txtStock.Clear();
				cbPhoto.SelectedIndex = -1;

				MessageBox.Show("Product added successfully.");

				pictureBox.Image.Dispose();
				pictureBox.Image = null;
				LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void LoadImageFiles(string directoryPath)
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    var imageFiles = Directory.GetFiles(directoryPath, "*.*")
                                              .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".jpeg") || s.EndsWith(".bmp"))
                                              .ToArray();
                    cbPhoto.Items.Clear();

                    foreach (var file in imageFiles)
                    {
                        cbPhoto.Items.Add(Path.GetFileName(file)); 
                    }
                }
                else
                {
                    MessageBox.Show("Directory does not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image files: " + ex.Message);
            }
        }
        private void cbPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPhoto.SelectedIndex >= 0)
    {
                string selectedImageName = cbPhoto.SelectedItem.ToString();


                string imageDirectory = ConfigurationSettings.AppSettings["ImageDirectory"];

          
                if (!imageDirectory.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    imageDirectory += Path.DirectorySeparatorChar;
                }

                string selectedImagePath = Path.Combine(imageDirectory, selectedImageName);
                if (File.Exists(selectedImagePath))
                {
                    try
                    {
                      
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No image found: " + selectedImagePath);
                    pictureBox.Image = null; 
                }
            }
        }
        private void Upload_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();

          
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

      
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
              
                string selectedImagePath = openFileDialog.FileName;

                string selectedImageName = Path.GetFileName(selectedImagePath);

               
                string imagesDirectory = ConfigurationSettings.AppSettings["ImageDirectory"];

              
                if (!Directory.Exists(imagesDirectory))
                {
                    Directory.CreateDirectory(imagesDirectory);
                }

                string destinationImagePath = Path.Combine(imagesDirectory, selectedImageName);

                // Sao chép ảnh vào thư mục Images
                try
                {
                    File.Copy(selectedImagePath, destinationImagePath, true); 
                    MessageBox.Show("Image uploaded successfully.");

         
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    pictureBox.Image = Image.FromFile(destinationImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading image: " + ex.Message);
                }
            }
        }

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormManagement formManagement = new FormManagement(Employeerights);
			formManagement.Show();
		}

		private void btLoad_Click(object sender, EventArgs e)
		{
			LoadProducts();
			txtID.Clear();
			txtName.Clear();
			txtImport.Clear();
			txtSellling.Clear();
			txtSize.Clear();
			txtQuantity.Clear();
			txtStock.Clear();
			cbPhoto.SelectedIndex = -1;
			MessageBox.Show("Data has been refreshed successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (pictureBox.Image != null)
			{
				pictureBox.Image.Dispose(); 
				pictureBox.Image = null;   
			}
		}

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter OrderID to search.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "SELECT * FROM Products WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderID", txtID.Text);

                    try
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

						dataPr.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Search success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No data found with entered OrderID.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
	}
}
