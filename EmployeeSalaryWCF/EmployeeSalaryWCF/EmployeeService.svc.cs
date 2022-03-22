using BusinessLayer.interfaces;
using BusinessLayer.Service;
using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeSalaryWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly ISalaryBL salaryBL;
        public EmployeeService()
        {
            salaryBL = new SalaryBL();
        }
        public string RegisteredEmployee(EmployeeContract employeeContract)
        {
            try
            {
                return salaryBL.RegisteredEmployee(employeeContract);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IList<EmployeeContract> Employees()
        {
            return salaryBL.Employees();
        }

        public string UpdateEmployee(EmployeeContract employeeContract, string Id)
        {
            int empId = Convert.ToInt32(Id);
            return salaryBL.UpdateEmployee(employeeContract, empId);
        }

        public string DeleteEmployee(string Id)
        {
            int empId = Convert.ToInt32(Id);
            return salaryBL.DeleteEmployee(empId);
        }

    }
}
