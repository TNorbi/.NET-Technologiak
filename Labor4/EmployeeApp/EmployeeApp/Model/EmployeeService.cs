using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    public class EmployeeService
    {
        private EmployeeEntities employeeEntities;
        public EmployeeService()
        {
            employeeEntities = new EmployeeEntities();
        }

        public List<EmployeeDTO> getAll()
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            try
            {
                var employees = from employee in employeeEntities.Employee
                                select employee;
                foreach (var employee in employees)
                    employeeDTOs.Add(new EmployeeDTO
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Age = employee.Age
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeDTOs;
        }
        public bool add(EmployeeDTO newEmployee)
        {
            bool isAdded = false;
            if (newEmployee.Age < 21 || newEmployee.Age > 58)
                throw new ArgumentException("Invalid limit for employee");
            try
            {
                var employee = new Employee();
                employee.Id = newEmployee.Id;
                employee.Name = newEmployee.Name;
                employee.Age = newEmployee.Age;
                employeeEntities.Employee.Add(employee);
                var numberOfRowsAffected = employeeEntities.SaveChanges();
                isAdded = numberOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isAdded;
        }
        public bool update(EmployeeDTO employeeToUpdate)
        {
            bool isUpdated = false;
            try
            {
                var employee = employeeEntities.Employee.Find(employeeToUpdate.Id);
                employee.Name = employeeToUpdate.Name;
                employee.Age = employeeToUpdate.Age;
                var numberOfRowsAffected = employeeEntities.SaveChanges();
                isUpdated = numberOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isUpdated;
        }
        public bool delete(int id)
        {
            bool isDeleted = false;
            try
            {
                var employee = employeeEntities.Employee.Find(id);
                employeeEntities.Employee.Remove(employee);
                var numberOfRowsEffected = employeeEntities.SaveChanges();
                isDeleted = numberOfRowsEffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isDeleted;
        }
        public EmployeeDTO search(int id)
        {
            EmployeeDTO employeeDTO = null;
            try
            {
                var employee = employeeEntities.Employee.Find(id);
                if (employee != null)
                {
                    employeeDTO = new EmployeeDTO()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Age = employee.Age
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeDTO;
        }
    } 
}
