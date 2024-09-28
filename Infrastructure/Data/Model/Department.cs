using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Model
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        
        public string? DepartmentName { get; set; }  

        public int? EmployeesTotal { get; set; }

        public string? Location { get; set; }

        public bool? IsActive { get; set; } = true;

        //public DateTime? CreateDate { get; set; }

        //public string? CreatedBy { get; set; } 

        //public string? ModifiedBy { get; set; }

        //public DateTime ModifiedDate { get; set; }
    }
}
