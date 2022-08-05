using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        internal string Designation { get; set; }
        private string CareerGoals { get; set; }
        protected double Salary { get; set; }
        protected static Employee[] GetAll()
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee() { Id = 1, Name = "Parikshit Verma", Designation = "Analyst", CareerGoals = "CEO ban na hai", Salary = 500000 };
            employees[1] = new Employee() { Id = 2, Name = "Parikshit Verma", Designation = "Analyst", CareerGoals = "CTO bhi banunga", Salary = 500000 };
            return employees;
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"{Name} is a {Designation}. His/Her Emp ID is {Id}");
        }
        protected static double GetSalary(Employee emp)
        {
            return emp.Salary;
        }
        public Employee()
        {
            CareerGoals = "Pata nahi :')";
            Salary = 200000;
        }
        public Employee(string careerGoals, double salary)
        {
            Salary = salary;
            CareerGoals = careerGoals;
        }
        public void GetPrivateProtectedDetails(string password)
        {
            if (password == "SahiPassword")
            {
                string result = string.Empty;
                
                Console.WriteLine($"Salary: INR {Salary}, Career Goals: {CareerGoals}");
            }
            else
            {
                Console.WriteLine($"You are unauthorized to access this info");
            }
        }
    }
}
