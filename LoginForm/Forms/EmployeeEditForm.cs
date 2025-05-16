using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EmployeeManagementSystem.Forms
{
	public partial class EmployeeEditForm : DevExpress.XtraEditors.XtraForm
	{
		private string _employeeID;
		public EmployeeEditForm(string employeeID)
		{
			InitializeComponent();
			_employeeID = employeeID;
			teEmployeeID.Text = _employeeID;
		}


	}
}