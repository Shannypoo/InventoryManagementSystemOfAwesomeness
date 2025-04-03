
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using LoginForm.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class managerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string connectionString = @"Data Source=DESKTOP-LIQC4BH\SQLEXPRESS;Initial Catalog=IT3232SQLAdventures;Integrated Security=True;";

        public managerForm()
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

        private void addEmployeeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait...");
            SplashScreenManager.Default.SetWaitFormDescription("Loading Job Position Add Form...");
            Thread.Sleep(1000);
            SplashScreenManager.CloseForm();
            CloseAllChildForm();

            AddNewEmployeeRF addNewEmployeeRF = new AddNewEmployeeRF();
            this.IsMdiContainer = true;
            addNewEmployeeRF.MdiParent = this;
            addNewEmployeeRF.Show();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
