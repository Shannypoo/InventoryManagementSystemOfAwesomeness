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
        private string connectionString = @"DATA Source=LAB1-PC17; Initial Catalog=IT3232SQLAdventures; User ID=sa; Password=123456";

        public AddNewEmployeeRF()
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

        private void windowsuiButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("Save"))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string InsertEmployees = @"";

                        connection.Execute(InsertEmployees, new
                        {

                        });
                        MessageBox.Show("Contact Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred during Adding Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                } else if (btn.Tag != null && btn.Tag.Equals("Cancel"))
            {
                this.Close();
            }
        }
    }
}