using CommonLayer.Contracts;
using RepositoryLayer.interfaces;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class SalaryRL : ISalaryRL
    {
        empsalaryEntities employeeManagementEntitiesObj;

        public SalaryRL()
        {
            employeeManagementEntitiesObj = new empsalaryEntities();
        }

        public int RegisteredEmployee(EmployeeContract employeeContract)
        {

            employee emp = new employee()
            {
                name = employeeContract.name,
                salary = employeeContract.salary,

                email = employeeContract.email
            };
            employeeManagementEntitiesObj.employees.Add(emp);
            return employeeManagementEntitiesObj.SaveChanges();
        }

        public IList<EmployeeContract> Employees()
        {
            var query = (from a in employeeManagementEntitiesObj.employees select a).Distinct();
            List<EmployeeContract> employeeData = new List<EmployeeContract>();

            query.ToList().ForEach(x =>
            {
                employeeData.Add(new EmployeeContract
                {
                    Id = x.Id,
                    name = x.name,
                    salary = (int)x.salary,
                    email = x.email

                });
            });

            return employeeData;

        }

        public int UpdateEmployee(EmployeeContract employeeContract, int Id)
        {
            employee employee = employeeManagementEntitiesObj
                .employees.Find(Id);
            if (employee != null)
            {
                employee.email = employeeContract.email;
                employee.name = employeeContract.name;
                employee.salary = employeeContract.salary;
                
                return employeeManagementEntitiesObj.SaveChanges();
            }
            else
            {
                throw new Exception("Employee do not exists");
            }
        }


        public int DeleteEmployee(int Id)
        {
            var employee = (from a in employeeManagementEntitiesObj.employees
                            where a.Id == Id
                            select a).FirstOrDefault();
            if (employee != null)
            {
                employeeManagementEntitiesObj.employees.Remove(employee);
                return employeeManagementEntitiesObj.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

    }
}
