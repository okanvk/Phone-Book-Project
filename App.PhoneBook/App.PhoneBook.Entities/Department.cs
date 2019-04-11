using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.PhoneBook.Entities
{
    public class Department : IEntity
    {

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
