using Dapper;
using DevExpress.XtraDiagram.Bars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Import.OpenXml;
using EmployeeManagementSystem.Repositories;
using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm.Forms
{
	public partial class ManagerInventoryForm : DevExpress.XtraEditors.XtraForm
	{
		private string connectionString = GlobalSettings.GetConnectionString();

		public ManagerInventoryForm()
		{
			InitializeComponent();
			LoadCategories();
			LoadInventory();
		}
		private void ClearTextEdits() 
		{
			teStockName.Clear();
			teQuantity.Clear();
			teUnitPrice.Clear();
			cbStockStatus.Clear();
			teUnitPrice.Clear();
			meDescription.Clear();

		}
		private void LoadCategories()
		{
			string query = "SELECT CategoryID, CategoryName FROM dbo.Categories";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var categories = connection.Query<AllModels>(query).ToList();
				lpeCategory.Properties.DataSource = categories;
				lpeCategory.Properties.DisplayMember = "CategoryName";
				lpeCategory.Properties.ValueMember = "CategoryID";
			}
		}

		private void LoadInventory()
		{
			string query = @"SELECT [InventoryID],[Quantity],c.CategoryName,[UnitPrice],[LastUpdated],
                            [StockName],[Description],[StockStatus],[DateAdded] 
                            FROM [Warehouse].[dbo].[Inventory] e 
                            LEFT JOIN Categories c ON c.CategoryID = e.CategoryID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var inventory = connection.Query<AllModels>(query).ToList();
				gcInventory.DataSource = inventory;
			}
		}

		private int GetCategoryID()
		{
			if (lpeCategory.EditValue != null)
			{
				return Convert.ToInt32(lpeCategory.EditValue);
			}
			return 0;
		}

		private void InsertIntoInventory(AllModels inventory)
		{
			
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					string insertQuery = @"INSERT INTO Inventory (
                        Quantity, CategoryID, UnitPrice, LastUpdated, StockName, 
                        Description, StockStatus, DateAdded) 
                        VALUES (
                        @Quantity, @CategoryID, @UnitPrice, @LastUpdated, @StockName, 
                        @Description, @StockStatus, @DateAdded)";

					connection.Execute(insertQuery, new
					{
						inventory.Quantity,
						inventory.CategoryID,
						inventory.UnitPrice,
						LastUpdated = DateTime.Now,
						inventory.StockName,
						inventory.Description,
						inventory.StockStatus,
						inventory.DateAdded
					});
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred during Adding Item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			if (!ValidateInputs()) return;
			DateTime DateAdded = DateTime.Now.Date;

			AllModels items = new AllModels
			{
				StockName = teStockName.Text,
				CategoryID = GetCategoryID(),
				UnitPrice = Convert.ToDouble(teUnitPrice.Text.Trim()),
				StockStatus = cbStockStatus.Text,
				Quantity = Convert.ToInt32(teQuantity.Text.Trim()),
				Description = meDescription.Text,
				DateAdded = DateAdded
			};

			InsertIntoInventory(items);
			LoadInventory();
			ClearTextEdits();
		}
		
		private void teSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		{
			gvInventory.ApplyFindFilter(e.NewValue as string);
		}
		private bool ValidateInputs()
		{
			if (string.IsNullOrWhiteSpace(teStockName.Text))
			{
				MessageBox.Show("Stock Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				teStockName.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(lpeCategory.Text))
			{
				MessageBox.Show("Category is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				lpeCategory.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(teUnitPrice.Text))
			{
				MessageBox.Show("Unit Price is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				teUnitPrice.Focus();
				return false;
			}

			if (cbStockStatus.Text == null)
			{
				MessageBox.Show("Stock Status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbStockStatus.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(teQuantity.Text))
			{
				MessageBox.Show("Quantity is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				teQuantity.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(meDescription.Text))
			{
				MessageBox.Show("Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				meDescription.Focus();
				return false;
			}


			return true;
		}

		private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			int itemID = Convert.ToInt32(gvInventory.GetFocusedRowCellValue("InventoryID"));
			if (!ValidateInputs()) return;

			string stockName = teStockName.Text;
			int quantity = Convert.ToInt32(teQuantity.Text);
			string category = Convert.ToString(GetCategoryID());
			decimal unitPrice = Convert.ToDecimal(teUnitPrice.Text.Trim());
			string stockStatus = cbStockStatus.Text;
			string description = meDescription.Text;
			DateTime lastUpdated = DateTime.Now;
			

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
					LoadInventory();
					ClearTextEdits();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred during Adding Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			int itemID = Convert.ToInt32(gvInventory.GetFocusedRowCellValue("InventoryID"));
			
			DialogResult result = XtraMessageBox.Show(
			"Are you sure you want to delete this item?","Confirm Delete",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question
			);

			if (result == DialogResult.Yes) 
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string deleteSql = "DELETE FROM Inventory WHERE InventoryID  = @InventoryID ";
					int rowsAffected = connection.Execute(deleteSql, new { InventoryID = itemID });
				}
				LoadInventory();
				XtraMessageBox.Show("Product Successfully Deleted!");
			} 
		
				
		}
	}
}
