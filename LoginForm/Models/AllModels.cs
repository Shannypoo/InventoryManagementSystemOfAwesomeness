using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Models
{
    public class AllModels
    {
        //Accounts
        public string AccountUsername { get; set; }
        public string AccountPassword { get; set; }


        //Categories
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //Inventory
        public int InventoryID { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string StockName { get; set; }
        public string Description { get; set; }
        public string StockStatus { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime DateAdded { get; set; }

        //Position
        public int PositionID { get; set; }
        public string PositionName { get; set; }

        //Departments

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
