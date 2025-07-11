using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repositories
{
	public static class GlobalSettings

	{
		public static string GetConnectionString() 
		{
			//string sstring = @"DATA Source=LAB1-PC17; Initial Catalog=Warehouse; User ID=sa; Password=123456";
			string sstring = @"DATA Source=MYLITTLEWARMACH\SQLEXPRESS; Initial Catalog=Warehouse; Integrated Security=True";
			return sstring;
		}

	}
}
