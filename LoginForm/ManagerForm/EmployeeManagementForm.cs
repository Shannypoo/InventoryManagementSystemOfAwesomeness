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

            InventoryForm employeeRF = new InventoryForm();
           
            employeeRF.Show();
        }
    }
}