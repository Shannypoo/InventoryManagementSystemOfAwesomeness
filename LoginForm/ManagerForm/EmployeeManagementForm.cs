using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using LoginForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.ManagerForm
{
    public partial class EmployeeManagementForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }
        private void CloseAllChildForm()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait...");
            SplashScreenManager.Default.SetWaitFormDescription("Loading Employee Add Form...");
            Thread.Sleep(1000);
            SplashScreenManager.CloseForm();
            CloseAllChildForm();

            AddNewEmployeeRF employeeRF = new AddNewEmployeeRF();
            this.IsMdiContainer = true;
            employeeRF.MdiParent = this;
            employeeRF.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait...");
            SplashScreenManager.Default.SetWaitFormDescription("Loading Inventory...");
            Thread.Sleep(1000);
            SplashScreenManager.CloseForm();
            CloseAllChildForm();

            ManagerInventoryForm ManagerInventory = new ManagerInventoryForm();
            this.IsMdiContainer = true;
            ManagerInventory.MdiParent = this;
            ManagerInventory.Show();
        }


        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait...");
            SplashScreenManager.Default.SetWaitFormDescription("Logging Out...");
            Thread.Sleep(1000);
            SplashScreenManager.CloseForm();
            CloseAllChildForm();

            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait...");
            SplashScreenManager.Default.SetWaitFormDescription("Loading List of Employees...");
            Thread.Sleep(1000);
            SplashScreenManager.CloseForm();
            CloseAllChildForm();

            ListofEmployee employee_List = new ListofEmployee();
            this.IsMdiContainer = true;
            employee_List.MdiParent = this;
            employee_List.Show();
        }
    }
}