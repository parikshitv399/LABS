using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpBL
{
    public class Employee
    {
        public int SickLeaveQty = 10;
        public int PaidLeaveQty = 10;
        public int UnPaidLeaveQty = 10;
        public int COVIDLeaveQty = 7;
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpSalary { get; set; }
        public void Work()
        {
            Console.WriteLine($"{EmpName} works as a {EmpDesignation}");
        }
        public enum LeaveTypes
        {
            SickLeave,
            PaidLeave,
            UnPaidLeave,
            COVIDLeave
        }
        public LeaveTypes TypeOfLeave { get; set; }
        public void ApplyLeave()
        {
            Console.WriteLine("Please input the type of leave from the following:\n1)Sick Leave\n2) Paid Leave\n3) Unpaid Leave\n4) COVID Leave");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    TypeOfLeave = LeaveTypes.SickLeave;
                    SickLeaveQty--;
                    Console.WriteLine($"{SickLeaveQty} more sick days are available for you!");
                    break;
                case "2": 
                    TypeOfLeave = LeaveTypes.PaidLeave;
                    PaidLeaveQty--;
                    Console.WriteLine($"{PaidLeaveQty} more paid leave days are available for you!");
                    break;
                case "3": 
                    TypeOfLeave = LeaveTypes.UnPaidLeave;
                    UnPaidLeaveQty--;
                    Console.WriteLine($"{UnPaidLeaveQty} more unpaid leave days are available for you!");
                    break;
                case "4": 
                    TypeOfLeave = LeaveTypes.COVIDLeave;
                    COVIDLeaveQty--;
                    Console.WriteLine($"{COVIDLeaveQty} more COVID sick days are available for you!");
                    break;

                default:
                    throw new Exception("Invalid Shape");
                    break;
            }
        }
    }
}
