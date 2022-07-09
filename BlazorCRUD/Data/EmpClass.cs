using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmpClass
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

    }
}
