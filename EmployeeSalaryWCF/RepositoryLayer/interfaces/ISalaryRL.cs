using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.interfaces
{
    public interface ISalaryRL
    {
        int RegisteredEmployee(EmployeeContract employeeContract);
        IList<EmployeeContract> Employees();
        int UpdateEmployee(EmployeeContract employeeContract, int Id);
        int DeleteEmployee(int Id);
    }
}
