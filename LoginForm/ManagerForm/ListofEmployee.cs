using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
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
        private string connectionString = @"DATA Source=LAB1-PC17; Initial Catalog=Warehouse; User ID=sa; Password=123456";

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
    }

}