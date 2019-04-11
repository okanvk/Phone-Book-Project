using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.PhoneBook.Entities
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Please Enter Firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please Enter LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please Enter Phone Number")]
        public string PhoneNumber { get; set; }

        public int? DepartmentId { get; set; }

        public int? ParentEmployeeId { get; set; }

        public virtual Employee ParentEmployee { get; set; }

        [BindNever]
        public DateTime Date { get; set; }
    }
}
