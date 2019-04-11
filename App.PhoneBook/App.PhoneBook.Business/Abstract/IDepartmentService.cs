using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.Business.Abstract
{
    public interface IDepartmentService 
    {
        void Add(Department department);

        void Update(Department department);

        void Delete(Department department);

        List<Department> GetDepartments();

        Department GetDepartmentById(int id);

    }
}
