using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using EmployeeManagementSystem.Forms;
using EmployeeManagementSystem.Repositories;
using LoginForm.Models;
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

namespace LoginForm.ManagerForm
{
	public partial class ListofEmployee : DevExpress.XtraEditors.XtraForm
	{
		public string connectionString = GlobalSettings.GetConnectionString();
		public ListofEmployee()
		{
			InitializeComponent();
			LoadEmployees();
		}
		public void LoadEmployees()
		{
			gcEmployees.DataSource = GetEmployees();
		}
		private List<AllModels> GetEmployees()
		{
			IEnumerable<AllModels> emps;
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
                string query = @"SELECT e.EmployeeID, (FirstName + ' ' +  CASE WHEN MiddleName = '' THEN ' ' 
                                                                 ELSE LEFT(MiddleName, 1) + '. ' END 
                                        + ' ' + LastName + ' ' + NameExtension) AS FullName,
	                                   DateOfBirth,   
	                                   Address,
	                                   ContactNo,
									   dept.DepartmentName,
									   post.PositionName,
									   ea.AccountUsername,
									   ea.AccountPassword,
									   ep.EmployeePicture
                                FROM Employees e
								LEFT JOIN Departments dept
								ON e.DepartmentID = dept.DepartmentID
								LEFT JOIN Positions post
								ON e.PositionID = post.PositionID
								LEFT JOIN EmployeeAccounts ea
								ON e.EmployeeID = ea.EmployeeID
								LEFT JOIN EmployeePhotos ep
								ON ep.EmployeeID = e.EmployeeID"; 
				emps = connection.Query<AllModels>(query, commandType: CommandType.Text);
			}
			return emps.ToList();
		}

		private void teSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		{
			gvEmployees.ApplyFindFilter(e.NewValue as string);
		}

		private void EditButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			string employeeID = Convert.ToString(gvEmployees.GetFocusedRowCellValue("EmployeeID"));
			EmployeeEditForm editForm = new EmployeeEditForm(employeeID, this);
			editForm.ShowDialog();
		}

		private void DeleteButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			string employeeID = Convert.ToString(gvEmployees.GetFocusedRowCellValue("EmployeeID"));

			DialogResult result = XtraMessageBox.Show(
			"Are you sure you want to delete this Employee?", "Confirm Delete",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question
			);

			if (result == DialogResult.Yes)
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string deleteSql = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID ";
					string deleteAccount = "DELETE FROM EmployeeAccounts WHERE EmployeeID = @EmployeeID";
					string deletePhoto = "DELETE FROM EmployeePhotos WHERE EmployeeID = @EmployeeID";
					int rowsAffected = connection.Execute(deleteSql, new { EmployeeID = employeeID });
					int rowsAffected2 = connection.Execute(deleteAccount, new { EmployeeID = employeeID });
					int rowsAffected3 = connection.Execute(deletePhoto, new { EmployeeID = employeeID });

				}
				LoadEmployees();
				XtraMessageBox.Show("Employee Successfully Deleted!");
			}
		}
	}

}