using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using EmployeeManagementSystem.Repositories;
using LoginForm.ManagerForm;
using LoginForm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace EmployeeManagementSystem.Forms
{

	public partial class EmployeeEditForm : DevExpress.XtraEditors.XtraForm
	{
		public string connectionString = GlobalSettings.GetConnectionString();
		private string _employeeID;
		private ListofEmployee _parentForm;

		public EmployeeEditForm(string employeeID, ListofEmployee parent)
		{
			InitializeComponent();
			LoadPositionsandDepartments();


			_employeeID = employeeID;
			_parentForm = parent;
			GetEmployeeData(employeeID);
			LoadEmployeeData(_employeeID);
		}
		private void LoadEmployeeData(string employeeID)
		{
			DataTable empData = GetEmployeeData(employeeID);

			if (empData.Rows.Count > 0)
			{
				var row = empData.Rows[0];

				teEmployeeID.Text = row["EmployeeID"].ToString();
				teFirstName.Text = row["FirstName"].ToString();
				teMiddleName.Text = row["MiddleName"].ToString();
				teLastName.Text = row["LastName"].ToString();
				teNameExtension.Text = row["NameExtension"].ToString();
				meAddress.Text = row["Address"].ToString();
				teContactNumber.Text = row["ContactNo"].ToString();

				// Date
				if (row["DateOfBirth"] != DBNull.Value)
					deDateOfBirth.EditValue = Convert.ToDateTime(row["DateOfBirth"]);
				else
					deDateOfBirth.EditValue = null;

				// Account info
				teEmployeeID2.Text = row["EmployeeID"].ToString();
				teUsername.Text = row["AccountUsername"].ToString();
				tePassword.Text = row["AccountPassword"].ToString();

				// Department and Position IDs
				if (row.Table.Columns.Contains("DepartmentID"))
					lpDepartments.EditValue = Convert.ToInt32(row["DepartmentID"]);

				if (row.Table.Columns.Contains("PositionID"))
					lpPositions.EditValue = Convert.ToInt32(row["PositionID"]);
			}
			else
			{
				XtraMessageBox.Show("Employee not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		public DataTable GetEmployeeData(string employeeID)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT e.[EmployeeID]\r\n      ,[FirstName]\r\n      ,[MiddleName]\r\n      ,[LastName]\r\n      ,[NameExtension]\r\n      ,[DateOfBirth]\r\n      ,[Address]\r\n      ,[ContactNo]\r\n      ,d.DepartmentID\r\n      ,p.PositionID\r\n      ,AccountUsername\r\n\t  ,AccountPassword\r\n  FROM [Warehouse].[dbo].[Employees] e\r\n  LEFT JOIN Departments d\r\n  ON d.DepartmentID = e.DepartmentID\r\n  LEFT JOIN Positions p\r\n  ON p.PositionID = e.PositionID\r\n  LEFT JOIN EmployeeAccounts ea\r\n  ON ea.AccountID = e.AccountID WHERE e.EmployeeID = @EmployeeID";

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
			string contactNumber = teContactNumber.Text;
			string address = meAddress.Text;
			string username = teUsername.Text;
			string password = tePassword.Text;

			int departments = GetDepartmentID();
			int position = GetPositionID();
			SaveImage(employeeId);
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					string editSql = "UPDATE Employees SET FirstName = @FirstName, MiddleName = @MiddleName ,LastName = @LastName, NameExtension = @NameExtension, DateOfBirth = @DateOfBirth, ContactNo = @ContactNumber, Address = @Address, DepartmentID = @DepartmentID, PositionID = @PositionID WHERE EmployeeID = @EmployeeID";


					connection.Execute(editSql, new
					{
						EmployeeID = employeeId,
						FirstName = firstName,
						MiddleName = middleName,
						LastName = lastName,
						NameExtension = nameExt,
						DateOfBirth = dateOfBirth,
						ContactNumber = contactNumber,
						Address = address,
						DepartmentID = departments,
						PositionID = position
					});

					string EditAccount = "UPDATE EmployeeAccounts SET AccountUsername = @AccountUsername, AccountPassword = @AccountPassword WHERE EmployeeID = @EmployeeID";

					connection.Execute(EditAccount, new
					{
						EmployeeID = employeeId,
						AccountUsername = username,
						AccountPassword = password,
					});


					MessageBox.Show("Employee Edited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					_parentForm.LoadEmployees();
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred during editing of the employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		private byte[] imageData;

		private void SaveImage(string strEmployeeID)
		{
			if (imageData != null)
			{
				try
				{
					string query = @"UPDATE EmployeePhotos SET EmployeePicture = @EmployeePicture WHERE EmployeeID = @EmployeeID";

					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();

						var parameters = new
						{
							EmployeeID = strEmployeeID,
							EmployeePicture = imageData
						};

						connection.Execute(query, parameters);
					}
				}
				catch (Exception ex)
				{
					XtraMessageBox.Show("Error: " + ex.Message, "Error saving image", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				XtraMessageBox.Show("Please select an image to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png;";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						peEmployeePicture.Image = Image.FromFile(openFileDialog.FileName);
						peEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

						using (MemoryStream ms = new MemoryStream())
						{
							peEmployeePicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can use other image formats
							imageData = ms.ToArray();
						}
					}
					catch (Exception ex)
					{
						XtraMessageBox.Show("Error: " + ex.Message, "Error Loading Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}