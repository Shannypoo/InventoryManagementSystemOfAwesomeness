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
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;

namespace LoginForm.Forms
{
    public partial class SalesForm : DevExpress.XtraEditors.XtraForm
    {
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

        private void SaveNCancel_ButtonClick(object sender, ButtonEventArgs e)
        {
            string EmployeeID = EmployeeIDTe.Text.Trim();
            string FirstName = FirstNameTe.Text.Trim();
            string MiddleName = MiddleNameTe.Text.Trim();
            string LastName = LastNameTe.Text.Trim();
            string NameExtension = NameExtensionTe.Text.Trim();
            DateTime DateOfBirth = Convert.ToDateTime(DateOfBirthDe.EditValue);
            string Address = AddressMe.Text.Trim();
            string ContactNo = ContactNoTe.Text.Trim();

            string Username = UsernameTe.Text.Trim();
            string Password = PasswordTe.Text.Trim();

            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("Save"))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string InsertEmployees = @"INSERT INTO Employees (EmployeeID, FirstName, MiddleName, LastName, NameExtension, DateOfBirth, Address, ContactNo)
                                                    VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @DateOfBirth, @Address, @ContactNo)";

                        connection.Execute(InsertEmployees, new
                        {
                            EmployeeID = EmployeeID,
                            FirstName = FirstName,
                            MiddleName = MiddleName,
                            LastName = LastName,
                            NameExtension = NameExtension,
                            DateOfBirth = DateOfBirth,
                            Address = Address,
                            ContactNo = ContactNo
                        });

                        string InsertAccount = @"INSERT INTO EmployeeAccounts (EmployeeID, AccountUsername, AccountPassword)
                                                    VALUES (@EmployeeID, @AccountUsername, @AccountPassword)";

                        connection.Execute(InsertAccount, new
                        {
                            EmployeeID = EmployeeID,
                            AccountUsername = Username,
                            AccountPassword = Password,
                        });
                        MessageBox.Show("Contact Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}