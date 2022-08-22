using System.ComponentModel.DataAnnotations;

namespace EmployeeOps.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int EmpWorkEx { get; set; }
        public double EmpSalary { get; set; }
    }
}
