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
            
        }

        

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Quantity amount is Required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmployee.Text))
            {
                MessageBox.Show("Employee In-Charge is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployee.Focus();
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
    }
}