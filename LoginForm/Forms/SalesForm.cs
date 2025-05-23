using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using EmployeeManagementSystem.Repositories;
using LoginForm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm.Forms
{
	public partial class SalesForm : DevExpress.XtraEditors.XtraForm
	{
		private static string connectionString = GlobalSettings.GetConnectionString();
		public SalesForm()
		{
			InitializeComponent();
			LoadSalesFromDatabase();
			LoadEmployees();
			teTransactionID.Text = GenerateID();
			LoadInventory();
		}
		private void ClearText()
		{
			txtQuantity.Text = string.Empty;
			cbStatus.Text = string.Empty;
			deDateOrdered.Text = string.Empty;
			deDateDelivered.Text = string.Empty;
			lueEmployee.EditValue = string.Empty;
			lueInventoryID.EditValue = string.Empty;

		}
		private static string GenerateID()
		{
			Random rand = new Random();
			string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			string id = string.Empty;

			for (int i = 0; i < 10; i++)
			{
				id += letters[rand.Next(letters.Length)];
			}
			return id;
		}
		private void LoadSalesFromDatabase()
		{
			gcSales.DataSource = GetSales();

		}
		private List<AllModels> GetSales()
		{
			IEnumerable<AllModels> emps;
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = @"SELECT
o.OrderID,
t.TransactionID,
e.EmployeeID,
e.FirstName + ' ' + LEFT(e.MiddleName,1) + '. ' + e.LastName AS FullName,
o.QuantityOrder,
t.DateDelivered,
t.DateOrdered,
o.Status,
StockName,
StockStatus
FROM Employees e
LEFT JOIN Transactions t
ON e.EmployeeID = t.EmployeeID
LEFT JOIN Orders o
ON o.TransactionID = t.TransactionID
LEFT JOIN Inventory i
ON o.InventoryID = i.InventoryID";
				emps = connection.Query<AllModels>(query, commandType: CommandType.Text);
			}
			return emps.ToList();
		}

		private void LoadEmployees()
		{
			string query = "SELECT\r\ne.EmployeeID,\r\ne.FirstName + ' ' + LEFT(e.MiddleName,1) + '. ' + e.LastName AS FullName FROM Employees e";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				var positions = connection.Query<AllModels>(query).ToList();
				lueEmployee.Properties.DataSource = positions;
			}
		}
		private void LoadInventory()
		{
			string query = "SELECT\r\ni.InventoryID,\r\ni.StockName\r\nFROM Inventory i";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				var inv = connection.Query<AllModels>(query).ToList();
				lueInventoryID.Properties.DataSource = inv;
			}
		}

		private bool ValidateInputs()
		{
			if (string.IsNullOrWhiteSpace(txtQuantity.Text))
			{
				MessageBox.Show("Quantity amount is Required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtQuantity.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(lueEmployee.Text))
			{
				MessageBox.Show("Employee In-Charge is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				lueEmployee.Focus();
				return false;
			}

			if (deDateOrdered.EditValue == null)
			{
				MessageBox.Show("Date Ordered is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				deDateOrdered.Focus();
				return false;
			}

			if (cbStatus.EditValue == null)
			{
				MessageBox.Show("Status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbStatus.Focus();
				return false;
			}

			return true;

		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			string Quantity = txtQuantity.Text.Trim();
			DateTime DateOrdered = Convert.ToDateTime(deDateOrdered.EditValue);
			DateTime DateDelivered = Convert.ToDateTime(deDateDelivered.EditValue);
			string TransactionID = teTransactionID.Text.Trim();
			string EmployeeInCharge = lueEmployee.EditValue.ToString();
			string Status = cbStatus.EditValue.ToString();
			string InventoryID = lueInventoryID.EditValue.ToString();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string InsertTransactions = @"INSERT INTO Transactions (TransactionID, EmployeeID, DateOrdered, DateDelivered)
                                                    VALUES (@TransactionID, @EmployeeID, @DateOrdered, @DateDelivered)";

				connection.Execute(InsertTransactions, new
				{
					TransactionID = TransactionID,
					EmployeeID = EmployeeInCharge,
					DateDelivered = DateDelivered,
					DateOrdered = DateOrdered

				});

				string InsertOrder = @"INSERT INTO Orders (Status, InventoryID, TransactionID, QuantityOrder)
                                                    VALUES (@Status, @InventoryID, @TransactionID, @QuantityOrder)";

				connection.Execute(InsertOrder, new
				{
					Status = Status,
					InventoryID = InventoryID,
					TransactionID = TransactionID,
					QuantityOrder = Quantity
				});
				LoadSalesFromDatabase();
				MessageBox.Show("Order Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearText();

			}
		}

		private void SalesForm_Load(object sender, EventArgs e)
		{

		}
	}
}
