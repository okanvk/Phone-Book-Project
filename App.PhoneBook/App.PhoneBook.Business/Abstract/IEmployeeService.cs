using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.Business.Abstract
{
    public interface IEmployeeService
    {

        void Add(Employee employee);

        void Update(Employee employee);

        bool Delete(int employeeId);

        List<Employee> GetAll();

        List<Employee> GetByDepartment(int departmentId);

        Employee GetById(int employeeId);
    }
}
