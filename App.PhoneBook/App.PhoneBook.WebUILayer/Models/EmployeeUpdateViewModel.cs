using App.PhoneBook.Entities;
using System.Collections.Generic;
using System.Linq;

namespace App.PhoneBook.WebUILayer.Models
{
   public class EmployeeUpdateViewModel : EmployeeAddViewModel
    {
        public EmployeeUpdateViewModel(List<Employee> employees, List<Department> departments,Employee employee) : base(employees,departments)
        {
            this.Employee = employee;
        }

        public Employee Employee { get; set; }



    }
}