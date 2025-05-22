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

namespace LoginForm.EmployeeForm
{
	public partial class EmployeeSideForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public EmployeeSideForm()
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
		private void InventoryBtn_ItemClick(object sender, ItemClickEventArgs e)
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

		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
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
	}
}