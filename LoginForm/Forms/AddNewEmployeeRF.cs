using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.Models;

namespace LoginForm.Forms
{
    public partial class AddNewEmployeeRF : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string connectionString = @"DATA Source=LAB1-PC17; Initial Catalog=Warehouse; User ID=sa; Password=123456";

        //The real string is up there this one is for me.
        //private string connectionString = @"DATA Source=MYLITTLEWARMACH\SQLEXPRESS; Initial Catalog=Warehouse; Integrated Security=True;";
        public AddNewEmployeeRF()
        {
            InitializeComponent();
            EmployeeIDTe.Text = GenerateID();
            LoadPositionsandDepartments();
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
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(EmployeeIDTe.Text))
            {
                MessageBox.Show("Employee ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmployeeIDTe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(FirstNameTe.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstNameTe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(LastNameTe.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastNameTe.Focus();
                return false;
            }

            if (DateOfBirthDe.EditValue == null)
            {
                MessageBox.Show("Birthdate is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateOfBirthDe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(AddressMe.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddressMe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(ContactNoTe.Text))
            {
                MessageBox.Show("Contact Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContactNoTe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(UsernameTe.Text))
            {
                MessageBox.Show("Account Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameTe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTe.Text))
            {
                MessageBox.Show("Account Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(lpDepartments.Text))
            {
                MessageBox.Show("Please Choose a Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTe.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(lpPositions.Text))
            {
                MessageBox.Show("Please Choose a Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTe.Focus();
                return false;
            }

            return true;
        }

        private void SaveNCancel_ButtonClick(object sender, ButtonEventArgs e)
        {
            //Employee Table
            string EmployeeID = EmployeeIDTe.Text.Trim();
            string FirstName = FirstNameTe.Text.Trim();
            string MiddleName = MiddleNameTe.Text.Trim();
            string LastName = LastNameTe.Text.Trim();
            string NameExtension = NameExtensionTe.Text.Trim();
            DateTime DateOfBirth = Convert.ToDateTime(DateOfBirthDe.EditValue);
            string Address = AddressMe.Text.Trim();
            string ContactNo = ContactNoTe.Text.Trim();
            //Employee Account
            string Username = UsernameTe.Text.Trim();
            string Password = PasswordTe.Text.Trim();
            //Employee Position
            int PositionID = GetPositionID();
            //Employee Department
            int DepartmentID = GetDepartmentID();

            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("Save"))
            {
                if (!ValidateInputs()) return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string InsertEmployees = @"INSERT INTO Employees (EmployeeID, FirstName, MiddleName, LastName, NameExtension, DateOfBirth, Address, ContactNo, DepartmentID, PositionID)
                                                    VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @DateOfBirth, @Address, @ContactNo, @DepartmentID, @PositionID)";

                        connection.Execute(InsertEmployees, new
                        {
                            EmployeeID = EmployeeID,
                            FirstName = FirstName,
                            MiddleName = MiddleName,
                            LastName = LastName,
                            NameExtension = NameExtension,
                            DateOfBirth = DateOfBirth,
                            Address = Address,
                            ContactNo = ContactNo,
                            DepartmentID = DepartmentID,
                            PositionID = PositionID,
                        });

                        string InsertAccount = @"INSERT INTO EmployeeAccounts (EmployeeID, AccountUsername, AccountPassword)
                                                    VALUES (@EmployeeID, @AccountUsername, @AccountPassword)";

                        connection.Execute(InsertAccount, new
                        {
                            EmployeeID = EmployeeID,
                            AccountUsername = Username,
                            AccountPassword = Password,
                        });

                        MessageBox.Show("Employee Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred during Adding Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (btn.Tag != null && btn.Tag.Equals("Cancel"))
            {
                this.Close();
            }
        }

        private void DateOfBirthDe_EditValueChanged(object sender, EventArgs e)
        {
            if (DateOfBirthDe.EditValue != null)
            {
                DateTime selectedDate = Convert.ToDateTime(DateOfBirthDe.EditValue);
                DateTime today = DateTime.Today;
                int age = today.Year - selectedDate.Year;
                if (selectedDate > today)
                {
                    MessageBox.Show("Date of Birth cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DateOfBirthDe.EditValue = null;
                }
                else if (selectedDate > today.AddYears(-age))
                {
                    age--;
                }

                if (age < 16)
                {
                    MessageBox.Show("User must be at least 16 years old.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DateOfBirthDe.EditValue = null;
                }
            }
        }
    }
}