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

namespace LoginForm.Forms
{
    public partial class AddNewEmployeeRF : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string connectionString = @"DATA Source=LAB1-PC17; Initial Catalog=Warehouse; User ID=sa; Password=123456";

        public AddNewEmployeeRF()
        {
            InitializeComponent();
            EmployeeIDTe.Text = GenerateID();
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

            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("Save"))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string InsertEmployees = @"INSERT INTO Employees (EmployeeID, FirstName, MiddleName, LastName, NameExtension, DateOfBirth, Address)
                                                    VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @DateOfBirth, @Address)";

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