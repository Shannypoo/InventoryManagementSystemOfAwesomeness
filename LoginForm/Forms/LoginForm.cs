using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using LoginForm.EmployeeForm;
using LoginForm.ManagerForm;

namespace LoginForm
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        string connectionString = "Data Source=LAB1-PC17;Initial Catalog=Warehouse; User ID=sa; Password=123456;";

        public LoginForm()
        {
            InitializeComponent();

        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            string adminemail = "admin@example.com";
            string adminpass = "admin123";

            string inputEmail = emailTxt.Text.Trim();
            string inputPassword = passTxt.Text.Trim();

            // Admin login
            if (inputEmail == adminemail && inputPassword == adminpass)
            {
                XtraMessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                EmployeeManagementForm mainForm = new EmployeeManagementForm();
                mainForm.Show();
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT * FROM EmployeeAccounts 
                             WHERE AccountUsername = @AccountUsername 
                             AND AccountPassword = @AccountPassword";

                    var user = connection.QueryFirstOrDefault(query, new
                    {
                        AccountUsername = inputEmail,
                        AccountPassword = inputPassword
                    });

                    if (user != null)
                    {
                        XtraMessageBox.Show("Welcome Employee " + inputEmail, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        EmployeeSideForm employeeForm = new EmployeeSideForm();
                        employeeForm.Show();
                        return;
                    }
                    else
                    {
                        XtraMessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


