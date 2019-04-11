using App.PhoneBook.Business.Abstract;
using App.PhoneBook.Entities;
using App.PhoneBook.WebUILayer.IdentityEntities;
using App.PhoneBook.WebUILayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.PhoneBook.WebUILayer.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IEmployeeService employeeService;
        private SignInManager<CustomIdentityUser> signInManager;
        private IDepartmentService departmentService;

        public AdminController(IDepartmentService departmentService,IEmployeeService employeeService,SignInManager<CustomIdentityUser> signInManager)
        {
            this.signInManager = signInManager;
            this.employeeService = employeeService;
            this.departmentService = departmentService;
        }

        public IActionResult Index()
        {

            List<Employee> employees = this.employeeService.GetAll();

            EmployeesListAdminViewModel model = new EmployeesListAdminViewModel{
                Employees = employees
            };

            return View(model);
        }

        public IActionResult DeleteEmployee(int employeeId)
        {
            var state = this.employeeService.Delete(employeeId);
            if (state){
                TempData.Add("message", "Employee deleted");
            }
            else {
                TempData.Add("message", "Employee have manager role. He/She can't be deleted");
            }
            return RedirectToAction("Index","Admin");
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int employeeId)
        {

            List<Department> departments = this.departmentService.GetDepartments();      
            Employee employee = this.employeeService.GetById(employeeId);
          //  List<Employee> employees = this.employeeService.GetAll().Where(e => e.EmployeeId != employee.EmployeeId).Where(e => e.ParentEmployeeId != employee.EmployeeId).ToList();
            List<Employee> employees = this.employeeService.GetAll().Where(e => e.EmployeeId != employee.EmployeeId && e.ParentEmployeeId != employee.EmployeeId).ToList();




            EmployeeUpdateViewModel model = new EmployeeUpdateViewModel(employees, departments, employee);                             

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeService.Update(employee);
                TempData.Add("message", "Employee updated");
                return RedirectToAction("Index");
            }

            return RedirectToAction("UpdateEmployee");

        }
        public IActionResult Add()
        {
            List<Department> departments = this.departmentService.GetDepartments();
            List<Employee> employees = this.employeeService.GetAll();

            EmployeeAddViewModel model = new EmployeeAddViewModel(employees, departments);

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                this.employeeService.Add(employee);
                return RedirectToAction("Index");
            }

            List<Department> departments = this.departmentService.GetDepartments();
            List<Employee> employees = this.employeeService.GetAll();

            EmployeeAddViewModel model = new EmployeeAddViewModel(employees, departments);
            model.Employee = employee;

            return View(model);
        }

        public ActionResult Logout()
        {
            signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login", "Account");
        }

    }
}
