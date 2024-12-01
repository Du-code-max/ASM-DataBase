using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
	public partial class FormMenuShop : Form
	{
		public FormMenuShop()
		{
			InitializeComponent();
		}

		private void btBuy1_Click(object sender, EventArgs e)
		{
			string productName = "Mixi jacket";
			string productSize = "Size: 2xl";
			double productPrice = 3.24;

			string formattedPrice = productPrice.ToString("C2", new System.Globalization.CultureInfo("en-US"));

			string message = $"Product: {productName}\nSize: {productSize}\nPrice: {formattedPrice}\n\nAre you sure you want to buy this product??";

			DialogResult result = MessageBox.Show(message, "Purchase Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				MessageBox.Show("Purchase successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("You have cancelled your purchase..", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btBuy2_Click(object sender, EventArgs e)
		{
			string productName = "Mixi T-shirt";
			string productSize = "Size: 2xl";
			double productPrice = 3.10;

			string formattedPrice = productPrice.ToString("C2", new System.Globalization.CultureInfo("en-US"));

			string message = $"Product: {productName}\nSize: {productSize}\nPrice: {formattedPrice}\n\nAre you sure you want to buy this product??";

			DialogResult result = MessageBox.Show(message, "Purchase Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				MessageBox.Show("Purchase successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("You have cancelled your purchase..", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btBuy3_Click(object sender, EventArgs e)
		{
			string productName = "Shoe";
			string productSize = "Size: 40";
			double productPrice = 2.24;

			string formattedPrice = productPrice.ToString("C2", new System.Globalization.CultureInfo("en-US"));

			string message = $"Product: {productName}\nSize: {productSize}\nPrice: {formattedPrice}\n\nAre you sure you want to buy this product??";

			DialogResult result = MessageBox.Show(message, "Purchase Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				MessageBox.Show("Purchase successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("You have cancelled your purchase..", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btBuy4_Click(object sender, EventArgs e)
		{
			string productName = "Shorts";
			string productSize = "Size: L";
			double productPrice = 1.24;

			string formattedPrice = productPrice.ToString("C2", new System.Globalization.CultureInfo("en-US"));

			string message = $"Product: {productName}\nSize: {productSize}\nPrice: {formattedPrice}\n\nAre you sure you want to buy this product??";

			DialogResult result = MessageBox.Show(message, "Purchase Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				MessageBox.Show("Purchase successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("You have cancelled your purchase..", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
