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
using DevExpress.XtraEditors;
using EmployeeManagementSystem.Repositories;
using LoginForm.Models;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace EmployeeManagementSystem.Forms
{

	public partial class EmployeeEditForm : DevExpress.XtraEditors.XtraForm
	{
		public string connectionString = GlobalSettings.GetConnectionString();
		private string _employeeID;
		public EmployeeEditForm(string employeeID)
		{
			LoadPositionsandDepartments();
			InitializeComponent();
			_employeeID = employeeID;
			teEmployeeID.Text = _employeeID;
			teEmployeeID2.Text = _employeeID;	
		}
		public DataTable GetSuperHeroDetailsByIDWithAttributes(string employeeID)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT e.[EmployeeID],[FirstName] + ' ' + LEFT([MiddleName],1) + '. ' + [LastName] AS 'FullName',[NameExtension],[DateOfBirth],[Address],[ContactNo],d.DepartmentName,p.PositionName,ea.AccountUsername,ea.AccountPassword FROM [Warehouse].[dbo].[Employees] LEFT JOIN EmployeeAccounts ea\\r\\n  ON ea.AccountID = e.AccountID\\r\\n  LEFT JOIN Departments d\\r\\n  ON d.DepartmentID = e.DepartmentID\\r\\n  LEFT JOIN Positions p\\r\\n  ON p.PositionID = e.PositionID WHERE e.EnployeeID = @EmployeeID;";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// Add the parameter to the SqlCommand
					command.Parameters.AddWithValue("@EmployeeID", employeeID);

					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);
						return dataTable;
					}
				}
			}
		}
		private int GetDepartmentID()
		{
			if (lpDepartments == null || lpDepartments.EditValue == null)
			{
				return -1; // or throw an exception, or handle in validation
			}
			return Convert.ToInt32(lpDepartments.EditValue);
		}

		private int GetPositionID()
		{
			if (lpPositions == null || lpPositions.EditValue == null)
			{
				return -1; // or handle it similarly
			}
			return Convert.ToInt32(lpPositions.EditValue);
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			string employeeId = _employeeID;

			string firstName = teFirstName.Text;
			string middleName = teMiddleName.Text;
			string lastName = teLastName.Text;	
			string nameExt = teNameExtension.Text;
			DateTime dateOfBirth = Convert.ToDateTime(deDateOfBirth.EditValue);	
			int contactNumber = Convert.ToInt32(teContactNumber.Text);
			string address = meAddress.Text;
			string username = teUsername.Text;
			string password = tePassword.Text;
				
			int departments = GetDepartmentID();
			int position = GetPositionID();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					string editSql = "UPDATE Inventory SET Quantity = @Quantity, CategoryID = @CategoryID ,UnitPrice = @UnitPrice, LastUpdated = @LastUpdated, StockName = @StockName, Description = @Description, StockStatus = @StockStatus WHERE InventoryID = @InventoryID";


					connection.Execute(editSql, new
					{
						InventoryID = itemID,
						Quantity = quantity,
						CategoryID = category,
						UnitPrice = unitPrice,
						LastUpdated = lastUpdated,
						StockName = stockName,
						Description = description,
						StockStatus = stockStatus
					});


					MessageBox.Show("Employee Edited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
		
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred during Adding Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void LoadPositionsandDepartments()
		{
			string query = "SELECT PositionName, PositionID FROM dbo.Positions";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				var positions = connection.Query<AllModels>(query).ToList();
				lpPositions.Properties.DataSource = positions;
			}

			string aquery = "SELECT DepartmentName, DepartmentID FROM dbo.Departments";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				var departments = connection.Query<AllModels>(aquery).ToList();
				lpDepartments.Properties.DataSource = departments;

			}
		}
	}
}