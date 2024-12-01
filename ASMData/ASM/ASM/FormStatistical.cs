using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASM
{
	public partial class FormStatistical : Form
	{
		String Employeerights;
		String connectstring = @"Data Source=DESKTOP-708AVGT;Initial Catalog=ASMDATA;Integrated Security=True;TrustServerCertificate=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adt;
		DataTable dt = new DataTable();

		public FormStatistical(String employeerights)
		{
			Employeerights = employeerights;
			InitializeComponent();
			LoadStatistics();
		}

		private void LoadStatistics()
		{
			try
			{
				con = new SqlConnection(connectstring);
				con.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormManagement formManagement = new FormManagement(Employeerights);
			formManagement.Show();
		}


		private void btnCheckStock_Click_1(object sender, EventArgs e)
		{
			string productId = textBox1.Text.Trim(); 

			if (string.IsNullOrEmpty(productId))
			{
				MessageBox.Show("Please enter product id.");
				return;
			}

			try
			{
				con = new SqlConnection(connectstring);
				con.Open();

				
				cmd = new SqlCommand("SELECT ProductQuantity FROM Products WHERE ProductID = @ProductID", con);
				cmd.Parameters.AddWithValue("@ProductID", productId);

				object result = cmd.ExecuteScalar(); 

				if (result != null)
				{
					int productQuantity = Convert.ToInt32(result);
					lbProductStock.Text = $"Number of products: {productQuantity}";
				}
				else
				{
					lbProductStock.Text = "Product does not exist.";
				}

				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
	
			DateTime startDate = dateTimePickerStart.Value.Date;
			DateTime endDate = dateTimePickerEnd.Value.Date;

		
			LoadStatisticsByDateRange(startDate, endDate);

		}
		private void LoadStatisticsByDateRange(DateTime startDate, DateTime endDate)
		{
			try
			{
				con = new SqlConnection(connectstring);
				con.Open();

			
				cmd = new SqlCommand(@"
            SELECT SUM(od.Quantity * p.ProductSellingPrice) AS TotalRevenue
            FROM OrderDetails od
            JOIN Products p ON od.ProductID = p.ProductID
            JOIN Orders o ON o.OrderID = od.OrderID
            WHERE o.OrderDate >= @StartDate AND o.OrderDate <= @EndDate
            GROUP BY o.OrderDate
			", con);

			
				cmd.Parameters.AddWithValue("@StartDate", startDate);
				cmd.Parameters.AddWithValue("@EndDate", endDate);

				// Thực thi truy vấn và lấy kết quả
				object result = cmd.ExecuteScalar();
				if (result != DBNull.Value)
				{
					decimal totalRevenue = Convert.ToDecimal(result);
					label8.Text = "" + totalRevenue.ToString("C");
				}
				else
				{
					label8.Text = "0US$";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				con.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string productId = txtProductID.Text.Trim();
			string employeeId = txtEmployeeID.Text.Trim();

			
			if (!string.IsNullOrEmpty(productId))
			{
				
				LoadProductRevenueAndProfit(productId);
			}
			else if (!string.IsNullOrEmpty(employeeId))
			{
				
				LoadEmployeeRevenueAndProfit(employeeId);
			}
			else
			{
				MessageBox.Show("Please enter either Product ID or Employee ID.");
			}
		}

		private void LoadProductRevenueAndProfit(string productId)
		{
			try
			{
				con = new SqlConnection(connectstring);
				con.Open();

				
				string query = @"
            SELECT 
                p.ProductName,
                SUM(od.Quantity * (p.ProductSellingPrice - p.ProductImportPrice)) AS Profit,
                SUM(od.Quantity * p.ProductSellingPrice) AS Revenue
            FROM OrderDetails od
            INNER JOIN Products p ON od.ProductID = p.ProductID
            WHERE p.ProductID = @ProductID
            GROUP BY p.ProductName";

				cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@ProductID", productId);

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					decimal profit = reader.GetDecimal(1);
					decimal revenue = reader.GetDecimal(2);

					lblTotalRevenue.Text = $"Total Revenue: {revenue:C}";
					lblTotalProfit.Text = $"Total Profit: {profit:C}";
				}
				else
				{
					MessageBox.Show("No data found for this product ID.");
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		private void LoadEmployeeRevenueAndProfit(string employeeId)
		{
			try
			{
				con = new SqlConnection(connectstring);
				con.Open();

				
				string query = @"
            SELECT 
                e.EmployeeName,
                SUM(od.Quantity * (p.ProductSellingPrice - p.ProductImportPrice)) AS Profit,
                SUM(od.Quantity * p.ProductSellingPrice) AS Revenue
            FROM OrderDetails od
            INNER JOIN Products p ON od.ProductID = p.ProductID
            INNER JOIN Employees e ON od.EmployeeID = e.EmployeeID
            WHERE e.EmployeeID = @EmployeeID
            GROUP BY e.EmployeeName";

				cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					decimal profit = reader.GetDecimal(1);
					decimal revenue = reader.GetDecimal(2);

					lblTotalRevenue.Text = $"Total Revenue: {revenue:C}";
					lblTotalProfit.Text = $"Total Profit: {profit:C}";
				}
				else
				{
					MessageBox.Show("No data found for this employee ID.");
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}









