using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EmployeeManagementSystem;

namespace LoginForm {
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            {
                string email = "admin@example.com";
                string pass = "admin123";

                string inputEmail = emailTxt.Text.Trim();
                string inputPassword = passTxt.Text.Trim();

                if (inputEmail == email && inputPassword == pass)
                {
                    XtraMessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    managerForm mainForm = new managerForm();
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
