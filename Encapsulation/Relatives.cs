using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Relatives
    {
        public void Gossip()
        {
            Employee Parikshit = new Employee();
            AccountsExecutive ParikshitAccountExec = new AccountsExecutive();
            Console.WriteLine("** Salary, GetSalary are protected entities of Employee Class" +
                $"{Environment.NewLine} Hence, cannot be accessed by Chacha ji**");
            Parikshit.PrintDetails();
            ParikshitAccountExec.PrintDetails();
        }
    }
    internal class Auditor
    {
        public void PrintAccounts()
        {
            AccountsExecutive KpmgFinanceTeam = new AccountsExecutive();
            KpmgFinanceTeam.PrintDetails();
        }
    }
}
