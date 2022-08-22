using EmployeeOps.Models;

namespace EmployeeOps.Repo
{
    public class EmpRepo : IEmpRepo
    {
        private static List<Employee> _emp = new List<Employee>();
        public int HireEmp(Employee pEmp)
        {
            try
            {
                pEmp.EmpId = new Random().Next(100000,999999);
                _emp.Add(pEmp);
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return 0;
        }
        public List<Employee> ListEmp()
        {
            return _emp;
        }
        public bool UpdateDesignation(int pId, string NewDesignation)
        {
            try
            {
                var foundEmp = _emp.Where((m) => { return m.EmpId == pId; })
                                        .FirstOrDefault();
                //make the updates
                foundEmp.EmpDesignation = NewDesignation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool Resign(int pId)
        {
            //find
            var foundEmp = _emp.Where((m) => { return m.EmpId == pId; })
                                    .FirstOrDefault();
            _emp.Remove(foundEmp);
            return true;
        }
        public Employee GetEmployee(int pId)
        {
            var foundEmp = _emp.Where((m) => { return m.EmpId == pId; })
                                    .FirstOrDefault();
            return foundEmp;
        }
    }
}
