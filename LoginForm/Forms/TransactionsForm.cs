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

namespace EmployeeManagementSystem.Forms
{
	public partial class TransactionsForm : DevExpress.XtraEditors.XtraForm
	{
		private static string connectionString = GlobalSettings.GetConnectionString();

		public TransactionsForm()
		{
			InitializeComponent();
			LoadSalesFromDatabase();
		}

		private void LoadSalesFromDatabase()
		{
			gcTransaction.DataSource = GetSales();

		}
		private List<AllModels> GetSales()
		{
			IEnumerable<AllModels> emps;
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = @"SELECT [SalesID]
      ,[TransactionID]
      ,[EmployeeID]
      ,[FullName]
      ,[QuantityOrder]
      ,[UnitPrice]
      ,[StockName]
      ,[StockStatus]
      ,[DateDelivered]
      ,[DateOrdered]
      ,[Status]
      ,[OrderID]
  FROM [Warehouse].[dbo].[TransactionHistory]";
				emps = connection.Query<AllModels>(query, commandType: CommandType.Text);
			}
			return emps.ToList();
		}

		private void teSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		{
			gvTransaction.ApplyFindFilter(e.NewValue as string);

		}
	}
}