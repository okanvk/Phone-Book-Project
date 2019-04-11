using App.PhoneBook.Business.Abstract;
using App.PhoneBook.DataAccess.Abstract;
using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.Business.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeDal employeeDal;

        public EmployeeService(IEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }

        private Employee UpdateKeys(Employee employee)
        {
            if (employee.DepartmentId == -1)
                employee.DepartmentId = null;
            if (employee.ParentEmployeeId == -1)
                employee.ParentEmployeeId = null;
            return employee;
        }

        public void Add(Employee employee)
        {
            employee = this.UpdateKeys(employee);

            this.employeeDal.Add(employee);
        }

        public bool Delete(int employeeId)
        {
            Employee employee = employeeDal.Get(x => x.ParentEmployeeId == employeeId); 
            if(employee != null){
                return false;
            } else {
                Employee deletedEmployee = employeeDal.Get(x => x.EmployeeId == employeeId);
                this.employeeDal.Delete(deletedEmployee);
                return true;
            }

        }

        public List<Employee> GetAll()
        {
            return this.employeeDal.GetList();
        }

        public List<Employee> GetByDepartment(int departmentId)
        {
            if (departmentId == 0)
                return this.GetAll();
            else
                return this.employeeDal.GetList(x => x.DepartmentId == departmentId);
        }

        public Employee GetById(int employeeId)
        {
            return this.employeeDal.Get(x => x.EmployeeId == employeeId);
        }


        public void Update(Employee employee)
        {
            employee = this.UpdateKeys(employee);

            this.employeeDal.Update(employee);
        }
    }
}
