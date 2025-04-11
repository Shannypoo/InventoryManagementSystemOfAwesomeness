using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LoginForm.ManagerForm;

namespace LoginForm
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            {
                string adminemail = "admin@example.com";
                string adminpass = "admin123"; ;

                string inputEmail = emailTxt.Text.Trim();
                string inputPassword = passTxt.Text.Trim();

                // SQL Server Connection
                string connectionString = "Data Source=LAB1-PC17;Initial Catalog=Warehouse; Username=sa; Password=123456;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM Users WHERE AccountUsername = @AccountUsername AND AccountPassword = @AccountPassword";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AccountUsername", inputEmail);
                            cmd.Parameters.AddWithValue("@AccountPassword", inputPassword); // Note: Consider hashing for real apps

                            int userCount = (int)cmd.ExecuteScalar();

                            if (userCount > 0)
                            {
                                XtraMessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                EmployeeManagementForm mainForm = new EmployeeManagementForm();
                                mainForm.Show();
                            }
                            else
                            {
                                XtraMessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                        if (inputEmail == adminemail && inputPassword == adminpass)
                        {

                            XtraMessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            EmployeeManagementForm mainForm = new EmployeeManagementForm();
                            mainForm.Show();
                        }
                        else if (inputEmail == email && inputPassword == pass)
                        {

                            XtraMessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            EmployeeManagementForm mainForm = new EmployeeManagementForm();
                            mainForm.Show();
                        }
                        else
                        {
                            XtraMessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
            
            
            }   
        }
    }
}


