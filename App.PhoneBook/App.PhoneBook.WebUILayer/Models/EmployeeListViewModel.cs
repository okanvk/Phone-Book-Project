using App.PhoneBook.Entities;
using System.Collections.Generic;

namespace App.PhoneBook.WebUILayer.Models
{
   public class EmployeeListViewModel
    {
        public int PageSize { get; set; }
        public List<Employee> Employees { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int CurrentDepartment { get; internal set; }
    }
}