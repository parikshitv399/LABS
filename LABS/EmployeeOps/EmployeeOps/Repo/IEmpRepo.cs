using EmployeeOps.Models;

namespace EmployeeOps.Repo
{
    public interface IEmpRepo
    {
        int HireEmp(Employee pEmp);
        List<Employee> ListEmp();
        bool UpdateDesignation(int pId, string NewDesignation);
        bool Resign(int pId);
        Employee GetEmployee(int pId);

    }
}
