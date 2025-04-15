using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Import.OpenXml;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm.Forms
{
    public partial class ManagerInventoryForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = @"DATA Source=LAB1-PC17; Initial Catalog=Warehouse; User ID=sa; Password=123456";

        public ManagerInventoryForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadInventory();
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
        }
    }
}