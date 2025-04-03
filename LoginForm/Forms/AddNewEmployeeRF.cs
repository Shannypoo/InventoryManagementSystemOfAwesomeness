using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.Forms
{
    public partial class AddNewEmployeeRF : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
        private void AddNewEmployeeRF_Load(object sender, EventArgs e)
        {
            EmployeeIDTe.Text = GenerateID();
        }
    }
}