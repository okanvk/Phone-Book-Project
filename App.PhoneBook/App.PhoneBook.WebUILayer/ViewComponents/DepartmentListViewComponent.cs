using App.PhoneBook.Business.Abstract;
using App.PhoneBook.Entities;
using App.PhoneBook.WebUILayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.PhoneBook.WebUILayer.ViewComponents
{
    public class DepartmentListViewComponent : ViewComponent
    {

        private IDepartmentService departmentService;

        public DepartmentListViewComponent(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        public ViewViewComponentResult Invoke()
        {
            List<Department> departments = this.departmentService.GetDepartments();

            DepartmentListViewModel model = new DepartmentListViewModel
            {
                Departments = departments,
                CurrentDepartment = Convert.ToInt32(HttpContext.Request.Query["department"])
            };

            return View(model);
        }

    }
}
