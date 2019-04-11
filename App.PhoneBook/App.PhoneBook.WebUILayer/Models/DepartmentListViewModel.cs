using App.PhoneBook.Entities;
using System.Collections.Generic;

namespace App.PhoneBook.WebUILayer.Models
{
    public class DepartmentListViewModel
    {
        public List<Department> Departments { get; set; }

        public int CurrentDepartment { get; internal set; }
    }
}