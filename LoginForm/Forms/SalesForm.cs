using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.CodeParser;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;
using DevExpress.PivotGrid.OLAP;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using EmployeeManagementSystem.Repositories;
using LoginForm.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
			LoadPrices();
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
i.StockName,
i.StockStatus,
i.UnitPrice,
i.UnitPrice * o.QuantityOrder AS TotalPrice

FROM Orders o
LEFT JOIN Transactions t
ON o.TransactionID = t.TransactionID
LEFT JOIN Employees e
ON t.EmployeeID = e.EmployeeID
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
		private void LoadPrices()
		{
			string query = "SELECT\r\ni.InventoryID,\r\ni.StockName\r\n, i.UnitPrice FROM Inventory i";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				var inv = connection.Query<AllModels>(query).ToList();
				lueUnitPrice.Properties.DataSource = inv;
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
			int UnitPrice = Convert.ToInt32(lueUnitPrice.EditValue);

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

				string InsertOrder = @"INSERT INTO Orders (Status, InventoryID, TransactionID, QuantityOrder, UnitPrice)
                                                    VALUES (@Status, @InventoryID, @TransactionID, @QuantityOrder, @UnitPrice)";

				connection.Execute(InsertOrder, new
				{
					Status = Status,
					InventoryID = InventoryID,
					TransactionID = TransactionID,
					QuantityOrder = Quantity,
					UnitPrice = UnitPrice,
				});
				LoadSalesFromDatabase();
				MessageBox.Show("Order Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearText();

			}
		}

		private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			// Get the focused row handle
			int rowHandle = gvSales.FocusedRowHandle;

			if (rowHandle >= 0)
			{
				// Get data from the selected row
				int orderID = Convert.ToInt32(gvSales.GetRowCellValue(rowHandle, "OrderID"));
				var transactionID = gvSales.GetRowCellValue(rowHandle, "TransactionID");
				var quantityOrder = gvSales.GetRowCellValue(rowHandle, "QuantityOrder");
				var employeeInCharge = gvSales.GetRowCellValue(rowHandle, "FullName");
				string employeeID = gvSales.GetRowCellValue(rowHandle, "EmployeeID").ToString();
				var stockName = gvSales.GetRowCellValue(rowHandle, "StockName");
				var dateOrdered = gvSales.GetRowCellValue(rowHandle, "DateOrdered");
				var dateDelivered = gvSales.GetRowCellValue(rowHandle, "DateDelivered");
				var stockStatus = gvSales.GetRowCellValue(rowHandle, "StockStatus");
				var status = gvSales.GetRowCellValue(rowHandle, "Status");
				var unitPrice = gvSales.GetRowCellValue(rowHandle, "UnitPrice");
				var totalPrice = gvSales.GetRowCellValue(rowHandle, "TotalPrice");

				// Insert into archive table
				InsertToDeletedSalesTable(totalPrice, employeeID, orderID, transactionID, quantityOrder, employeeInCharge, stockName, dateOrdered, dateDelivered, stockStatus, status, unitPrice);

				// Then remove from original datasource (and database if necessary)
				DeleteFromSalesTable(orderID, transactionID);

				// Refresh the grid datasource
				LoadSalesFromDatabase(); // Or however you re-bind the data
			}
		}
		private void InsertToDeletedSalesTable(object totalPrice, string employeeID, int orderID, object transactionID, object quantityOrder, object employeeInCharge, object stockName, object dateOrdered, object dateDelivered, object stockStatus, object status, object unitPrice)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = @"INSERT INTO [dbo].[TransactionHistory]
   ([TransactionID]
   , [OrderID]
   , [EmployeeID]
   , [FullName]
   , [QuantityOrder]
   , [UnitPrice]
   , [StockName]
   , [StockStatus]
   , [DateDelivered]
   , [DateOrdered]
   , [Status]
,TotalPrice) 
VALUES
   (@TransactionID
   , @OrderID
   , @EmployeeID
   , @FullName
   , @QuantityOrder
   , @UnitPrice
   , @StockName
   , @StockStatus
   , @DateDelivered
   , @DateOrdered
   , @Status
,@TotalPrice)";
				

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@OrderID", orderID);
					cmd.Parameters.AddWithValue("@TransactionID", transactionID);
					cmd.Parameters.AddWithValue("@QuantityOrder", quantityOrder);
					cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
					cmd.Parameters.AddWithValue("@FullName", employeeInCharge);
					cmd.Parameters.AddWithValue("@StockName", stockName);
					cmd.Parameters.AddWithValue("@DateOrdered", dateOrdered);
					cmd.Parameters.AddWithValue("@DateDelivered", dateDelivered);
					cmd.Parameters.AddWithValue("@StockStatus", stockStatus);
					cmd.Parameters.AddWithValue("@Status", status);
					cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
					cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

					con.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}
		private void DeleteFromSalesTable(int orderID, object transactionID)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string deleteOrder = "DELETE FROM Orders WHERE OrderID = @OrderID";

				using (SqlCommand cmd = new SqlCommand(deleteOrder, con))
				{
					cmd.Parameters.AddWithValue("@OrderID", orderID);

					con.Open();
					cmd.ExecuteNonQuery();
				}
				string deleteTransaction = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";

				using (SqlCommand cmd = new SqlCommand(deleteTransaction, con))
				{
					cmd.Parameters.AddWithValue("@TransactionID", transactionID);

					
					cmd.ExecuteNonQuery();
				}
			}
		}


	}
}
