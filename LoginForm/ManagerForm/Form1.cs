
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
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

        
    }
}
