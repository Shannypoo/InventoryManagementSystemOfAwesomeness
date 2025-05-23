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

namespace LoginForm.Forms
{
    public partial class SalesForm : DevExpress.XtraEditors.XtraForm
    {
        private static string connectionString = GlobalSettings.GetConnectionString();
        public SalesForm()
        {
            InitializeComponent();
        }

        private static string GenerateID()
        {
            //Generates random strings for student ID
            Random rand = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string id = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                id += letters[rand.Next(letters.Length)];
            }
            return id;
        }



        private void LoadPositionsandDepartments()
        {
            string query = "SELECT EmployeeID FROM dbo.Employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var positions = connection.Query<AllModels>(query).ToList();
                lueEmployee.Properties.DataSource = positions;
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
            string Employee = lueEmployee.Text.Trim();
            DateTime DateOrdered = Convert.ToDateTime(deDateOrdered.EditValue);
            DateTime DateDelivered = Convert.ToDateTime(deDateDelivered.EditValue);
            string NameExtension = cbStatus.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string InsertEmployees = @"INSERT INTO Employees (OrderID, Status, TransactionID, LastName, NameExtension, DateOfBirth, Address, ContactNo, DepartmentID, PositionID)
                                                    VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @DateOfBirth, @Address, @ContactNo, @DepartmentID, @PositionID)";

                connection.Execute(InsertEmployees, new
                {
                
            });
            }
        }
    }
}