using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class AccountsExecutive : Employee
    {
        public override void PrintDetails()
        {
            var employees = Employee.GetAll();
            double companyEmpInvestment = 0;
            foreach (var emp in employees)
            {
                companyEmpInvestment += GetSalary(emp);
            }

            Console.WriteLine($"Total investment for all employees by KPMG: {companyEmpInvestment}");
        }
    }
}
