using BusinessLayer.interfaces;
using CommonLayer.Contracts;
using RepositoryLayer.interfaces;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class SalaryBL : ISalaryBL
    {
        ISalaryRL SalaryRL;

        public SalaryBL()
        {
            SalaryRL = new SalaryRL();
        }
        public string RegisteredEmployee(EmployeeContract employeeContract)
        {

            try
            {
                if (SalaryRL.RegisteredEmployee(employeeContract) != null)
                {
                    return "employee added sucessfully";
                }
                else
                {
                    return "Employee not added";
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IList<EmployeeContract> Employees()
        {
            IList<EmployeeContract> employeeContracts = SalaryRL.Employees();
            if (employeeContracts != null)
            {
                return employeeContracts;
            }
            else
            {
                return new List<EmployeeContract>();
            }
        }

        public string UpdateEmployee(EmployeeContract employeeContract, int Id)
        {
            if (SalaryRL.UpdateEmployee(employeeContract, Id) != null)
            {
                return "Employee updated successfully";
            }
            else
            {
                return "Employee not updated";
            }
        }

        public string DeleteEmployee(int Id)
        {
            if (SalaryRL.DeleteEmployee(Id) != null)
            {
                return "Employee deleted successfuly";
            }
            else
            {
                return "Employee does not exists.";
            }
        }
    }
}
