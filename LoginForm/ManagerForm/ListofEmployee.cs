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
		private void LoadEmployees()
		{
			gcEmployees.DataSource = GetEmployees();
		}
		private List<AllModels> GetEmployees()
		{
			IEnumerable<AllModels> emps;
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT e.[EmployeeID]\r\n      ,[FirstName] + ' ' + LEFT([MiddleName],1) + '. ' + [LastName] AS 'FullName'    \r\n      ,[NameExtension]\r\n      ,[DateOfBirth]\r\n      ,[Address]\r\n      ,[ContactNo]\r\n      ,d.DepartmentName\r\n      ,p.PositionName\r\n\t  ,ea.AccountUsername\r\n\t  ,ea.AccountPassword\r\n  FROM [Warehouse].[dbo].[Employees] e\r\n  LEFT JOIN EmployeeAccounts ea\r\n  ON ea.AccountID = e.AccountID\r\n  LEFT JOIN Departments d\r\n  ON d.DepartmentID = e.DepartmentID\r\n  LEFT JOIN Positions p\r\n  ON p.PositionID = e.PositionID\r\n";
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
			EmployeeEditForm editForm = new EmployeeEditForm(employeeID);
			editForm.Show();
		}

		private void DeleteButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{

		}
	}

}