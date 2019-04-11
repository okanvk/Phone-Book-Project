using App.PhoneBook.DataAccess.Abstract;
using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.DataAccess.Concrete
{
    public class EmployeeDal : EfEntityRepository<Employee,PhoneBookContext>,IEmployeeDal
    {
    }
}
