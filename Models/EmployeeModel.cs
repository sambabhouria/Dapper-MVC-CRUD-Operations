using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * We use this class to map db operations
 */
namespace DapperMVCCRUD.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}