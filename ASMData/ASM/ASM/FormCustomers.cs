using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ASM
{
	public partial class FormCustomers : Form
	{
		String Employeerights;
		String connectstring = @"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adt;
		DataTable dt = new DataTable();
		public FormCustomers(String employeerights)
		{
			Employeerights = employeerights;
			InitializeComponent();
		}

		private void FormCustomers_Load(object sender, EventArgs e)
		{
			LoadCustomers();
		}
		private void LoadCustomers()
		{
			con = new SqlConnection(connectstring);
			try
			{
				con.Open();
				cmd = new SqlCommand("SELECT * FROM Customers", con);
				adt = new SqlDataAdapter(cmd);
				dt.Clear();
				adt.Fill(dt);
				dataCr.DataSource = dt;
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

		private void btLoadCr_Click(object sender, EventArgs e)
		{
			LoadCustomers();
			txtCustomerID.Clear();
			txtCustomerName.Clear();
			txtCustomerPhone.Clear();
			txtCustomerEmail.Clear();
			txtCustomerAddress.Clear();
			txtUserCr.Clear();
			txtPassCr.Clear();
			MessageBox.Show("The data table has been refreshed.!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btAddCr_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
				string.IsNullOrWhiteSpace(txtCustomerPhone.Text) ||
				string.IsNullOrWhiteSpace(txtCustomerEmail.Text) ||
				string.IsNullOrWhiteSpace(txtCustomerAddress.Text) ||
				string.IsNullOrWhiteSpace(txtUserCr.Text) ||
				string.IsNullOrWhiteSpace(txtPassCr.Text))
			{
				MessageBox.Show("Please fill in all fields completely..", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True"))
			{
				using (SqlCommand cmd = new SqlCommand("INSERT INTO Customers (CustomersName, CustomersPhone, CustomersEmail, CustomersAddress, UserName, PassWord) " +
					"VALUES (@Name, @Phone, @Email, @Address, @UserName, @Pass)", con))
				{
					// Pass word SHA256
					string hashedPassword = HashPassword(txtPassCr.Text);

					cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
					cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
					cmd.Parameters.AddWithValue("@Email", txtCustomerEmail.Text);
					cmd.Parameters.AddWithValue("@Address", txtCustomerAddress.Text);
					cmd.Parameters.AddWithValue("@UserName", txtUserCr.Text);
					cmd.Parameters.AddWithValue("@Pass", hashedPassword);

					try
					{
						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							LoadCustomers(); 
							MessageBox.Show("Add customer successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtCustomerID.Clear();
							txtCustomerName.Clear();
							txtCustomerPhone.Clear();
							txtCustomerEmail.Clear();
							txtCustomerAddress.Clear();
							txtUserCr.Clear();
							txtPassCr.Clear();
						}
						else
						{
							MessageBox.Show("Add failed customers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		private string HashPassword(string password)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				StringBuilder builder = new StringBuilder();
				foreach (byte b in bytes)
				{
					builder.Append(b.ToString("x2"));
				}
				return builder.ToString();
			}
		}

		private void dataCr_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataCr.Rows[e.RowIndex];

				txtCustomerID.Text = row.Cells["CustomersID"].Value.ToString();
				txtCustomerName.Text = row.Cells["CustomersName"].Value.ToString();
				txtCustomerPhone.Text = row.Cells["CustomersPhone"].Value.ToString();
				txtCustomerEmail.Text = row.Cells["CustomersEmail"].Value.ToString();
				txtCustomerAddress.Text = row.Cells["CustomersAddress"].Value.ToString();
				txtUserCr.Text = row.Cells["UserName"].Value.ToString();
				txtPassCr.Text = row.Cells["PassWord"].Value.ToString();

				txtCustomerID.ReadOnly = true;
				txtCustomerName.ReadOnly = true;
				txtUserCr.ReadOnly = true;
				txtPassCr.ReadOnly = true;
			}
		}
		private void btEditCr_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtCustomerPhone.Text) ||
				string.IsNullOrWhiteSpace(txtCustomerEmail.Text) ||
				string.IsNullOrWhiteSpace(txtCustomerAddress.Text))
			{
				MessageBox.Show("Please fill in all information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True"))
			{
				string query = "UPDATE Customers SET CustomersPhone = @Phone, CustomersEmail = @Email, CustomersAddress = @Address WHERE CustomersID = @ID";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text); 
					cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
					cmd.Parameters.AddWithValue("@Email", txtCustomerEmail.Text);
					cmd.Parameters.AddWithValue("@Address", txtCustomerAddress.Text);

					try
					{
						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Edit customer success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtCustomerID.Clear();
							txtCustomerName.Clear();
							txtCustomerPhone.Clear();
							txtCustomerEmail.Clear();
							txtCustomerAddress.Clear();
							txtUserCr.Clear();
							txtPassCr.Clear();

							txtCustomerID.ReadOnly = false;
							txtCustomerName.ReadOnly = false;
							txtUserCr.ReadOnly = false;
							txtPassCr.ReadOnly = false;

							LoadCustomers(); 
						}
						else
						{
							MessageBox.Show("No changes were made.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btDeleteCr_Click(object sender, EventArgs e)
		{
			if (dataCr.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select a row to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string customerID = dataCr.SelectedRows[0].Cells["CustomersID"].Value.ToString();

			DialogResult confirmResult = MessageBox.Show(
				"Are you sure you want to delete this customer??",
				"Confirm deletion",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (confirmResult == DialogResult.Yes)
			{
				using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True"))
				{
					string query = "DELETE FROM Customers WHERE CustomersID = @ID";

					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@ID", customerID);

						try
						{
							con.Open();
							int rowsAffected = cmd.ExecuteNonQuery();

							if (rowsAffected > 0)
							{

								LoadCustomers();
								txtCustomerID.Clear();
								txtCustomerName.Clear();
								txtCustomerPhone.Clear();
								txtCustomerEmail.Clear();
								txtCustomerAddress.Clear();
								txtUserCr.Clear();
								txtPassCr.Clear();
								txtCustomerID.ReadOnly = false;
								txtCustomerName.ReadOnly = false;
								txtUserCr.ReadOnly = false;
								txtPassCr.ReadOnly = false;
								MessageBox.Show("Customer deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("No customers found to delete No customers found to delete.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btSearchCr_Click(object sender, EventArgs e)
		{
			string customerID = txtCustomerID.Text.Trim();
			string customerName = txtCustomerName.Text.Trim();
			if (string.IsNullOrWhiteSpace(customerID) && string.IsNullOrWhiteSpace(customerName))
			{
				MessageBox.Show("Please enter at least one search condition (ID or Name).");
				return;
			}
			StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Customers WHERE 1 = 1");
			if (!string.IsNullOrWhiteSpace(customerID))
			{
				queryBuilder.Append(" AND CustomersID = @ID");
			}

			if (!string.IsNullOrWhiteSpace(customerName))
			{
				queryBuilder.Append(" AND CustomersName LIKE @Name");
			}
			using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True"))
			{
				using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), con))
				{
					if (!string.IsNullOrWhiteSpace(customerID))
					{
						cmd.Parameters.AddWithValue("@ID", customerID);
					}
					if (!string.IsNullOrWhiteSpace(customerName))
					{
						cmd.Parameters.AddWithValue("@Name", "%" + customerName + "%"); 
					}
					try
					{
						con.Open(); 
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						if (dt.Rows.Count > 0)
						{
							dataCr.DataSource = dt; 
							MessageBox.Show("Find customers!");
							txtCustomerID.Clear();
							txtCustomerName.Clear();
						}
						else
						{
							MessageBox.Show("No customers found!");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message); 
					}
				}
			}
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormManagement fr = new FormManagement(Employeerights);
			fr.Show();
		}
	}
}

