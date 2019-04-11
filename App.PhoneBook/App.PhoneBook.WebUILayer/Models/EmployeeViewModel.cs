using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.PhoneBook.WebUILayer.Models
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Department Department { get; internal set; }
    }
}
