using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.PhoneBook.Business.Abstract;
using App.PhoneBook.Entities;
using App.PhoneBook.WebUILayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.PhoneBook.WebUILayer.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;

        private IDepartmentService departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
            this.employeeService = employeeService;
        }

        public IActionResult Index(int department = 0, int page = 1)
        {
            var employees = employeeService.GetByDepartment(department);

            var pageSize = 10;

            List<Employee> filteredEmployees = employees.Skip(pageSize * (page - 1)).Take(pageSize).ToList();

            EmployeeListViewModel model = new EmployeeListViewModel
            {
                PageCount = (int)Math.Ceiling(employees.Count / (double)pageSize),
                PageSize = pageSize,
                Employees = filteredEmployees,
                CurrentPage = page,
                CurrentDepartment = department
            };

            return View(model);
        }
        public IActionResult GetEmployeeDetails(int employeeId)
        {
            Employee manager = null;
            var employee = this.employeeService.GetById(employeeId);

            if (employee == null)
                return RedirectToAction("Index");
            else
            {
                Department department = departmentService.GetDepartmentById(Convert.ToInt32(employee.DepartmentId));
                if(employee.ParentEmployeeId != null)
                {
                    manager = this.employeeService.GetById(Convert.ToInt32(employee.ParentEmployeeId));
                }                
                employee.ParentEmployee = manager;
                         EmployeeViewModel model = new EmployeeViewModel
                         {
                             Employee = employee,
                             Department = department
                         };
                TempData.Add("no-cat", "No Categories");
                return View(model);
            }           
        }
    }
}