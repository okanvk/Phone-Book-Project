using App.PhoneBook.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.PhoneBook.WebUILayer.Models
{
    public class EmployeeAddViewModel
    {
        public EmployeeAddViewModel(List<Employee> employees,List<Department> departments)
        {
            setEmployees(employees);
            setDepartments(departments);
        }

        public List<SelectListItem> Employees;

        public List<SelectListItem> Departments;

        public virtual void setEmployees(List<Employee> employees)
        {

            Employees = new List<SelectListItem>();
            SelectListItem initial = new SelectListItem("Select Employee","-1");
            this.Employees.Add(initial);

            foreach (Employee employee in employees)
            {
                SelectListItem item = new SelectListItem(employee.FirstName + " - " +  employee.LastName, employee.EmployeeId.ToString());
                this.Employees.Add(item);
            }

        }
        public void setDepartments(List<Department> departments)
        {
            Departments = new List<SelectListItem>();
            SelectListItem initial = new SelectListItem("Select Department","-1");
            this.Departments.Add(initial);

            foreach (Department departmet in departments)
            {
                SelectListItem item = new SelectListItem(departmet.DepartmentName, departmet.DepartmentId.ToString());
                this.Departments.Add(item);
            }

        }

        public Employee Employee { get; set; }
    }
}
