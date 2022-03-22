using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.interfaces
{
    public interface ISalaryBL
    {
        string RegisteredEmployee(EmployeeContract employeeContract);
        IList<EmployeeContract> Employees();
        string UpdateEmployee(EmployeeContract employeeContract, int Id);
        string DeleteEmployee(int Id);
    }
}
