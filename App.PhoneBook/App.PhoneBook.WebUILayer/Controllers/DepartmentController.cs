using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.PhoneBook.Business.Abstract;
using App.PhoneBook.Entities;
using App.PhoneBook.WebUILayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.PhoneBook.WebUILayer.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private IDepartmentService departmentService;

        private IEmployeeService employeeService;

        public DepartmentController(IDepartmentService departmentService,IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            this.departmentService = departmentService;
        }

        public IActionResult Index()
        {

            var departments = this.departmentService.GetDepartments();

            DepartmentListViewModel model = new DepartmentListViewModel
            {
                Departments = departments
            };

            return View(model);
        }

        public IActionResult Add()
        {
            DepartmentAddViewModel model = new DepartmentAddViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (!string.IsNullOrEmpty(department.DepartmentName))
            {
                this.departmentService.Add(department);
                TempData.Add("message", "Department added");
                return RedirectToAction("Index");
            } else {
                TempData.Add("error-message", "Please enter department name");
                return View(new DepartmentAddViewModel());
            }
        }

        public IActionResult DeleteDepartment(int departmentId)
        {  
            var DepartmentEmployees = this.employeeService.GetByDepartment(departmentId);

            if(DepartmentEmployees.Count != 0){
                TempData.Add("message", "Department contains employees,can't be deleted");
            }
            else {
                Department department = this.departmentService.GetDepartmentById(departmentId);
                this.departmentService.Delete(department);
                TempData.Add("message", "Department deleted");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int departmentId)
        {

            DepartmentUpdateViewModel model = new DepartmentUpdateViewModel
            {
                Department = departmentService.GetDepartmentById(departmentId)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Department department)
        {
            if (!string.IsNullOrEmpty(department.DepartmentName))
            {
                departmentService.Update(department);
                TempData.Add("message", "Department Updated");
                return RedirectToAction("Index");
            }
            TempData.Add("error-message", "Department didn't be updated");
            return View(new DepartmentUpdateViewModel { Department = department });
        }
        

    }
}