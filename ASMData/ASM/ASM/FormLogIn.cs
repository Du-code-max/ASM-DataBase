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


namespace ASM
{
	public partial class FormLogIn : Form
	{
		string connectstring = @"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True";
		public FormLogIn()
		{
			InitializeComponent();
		}

		private void btLogIn_Click(object sender, EventArgs e)
		{
			string username = txtUser.Text.Trim();
			string password = txtPass.Text.Trim();

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Please enter full login information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True"))
			{
				connection.Open();

				string queryCustomer = "SELECT COUNT(*) FROM Customers WHERE UserName = @User AND PassWord = @Pass";
				using (SqlCommand cmdCustomer = new SqlCommand(queryCustomer, connection))
				{
					cmdCustomer.Parameters.AddWithValue("@User", username);
					cmdCustomer.Parameters.AddWithValue("@Pass", password);

					int customerCount = (int)cmdCustomer.ExecuteScalar();

					if (customerCount > 0)
					{
						MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						FormMenuShop formMenuShop = new FormMenuShop();
						formMenuShop.Show();
						this.Hide();
						return; 
					}
				}
				string queryEmployee = "SELECT EmployeeRights FROM Employee WHERE UserName = @Username AND PassWord = @Password";
				using (SqlCommand cmdEmployee = new SqlCommand(queryEmployee, connection))
				{
					cmdEmployee.Parameters.AddWithValue("@Username", username);
					cmdEmployee.Parameters.AddWithValue("@Password", password);
					string EmployeeRights = cmdEmployee.ExecuteScalar() as string;

					if (!string.IsNullOrEmpty(EmployeeRights))
					{
						FormManagement formManagement = new FormManagement(EmployeeRights);
						formManagement.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Incorrect account or password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		private void btRegister_Click(object sender, EventArgs e)
		{
			FormRegister formRegister = new FormRegister();
			formRegister.Show();
			this.Hide();
		}
	}
}

		


