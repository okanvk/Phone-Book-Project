using App.PhoneBook.Business.Abstract;
using App.PhoneBook.DataAccess.Abstract;
using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.Business.Concrete
{
    public class DepartmentService : IDepartmentService
    {
    
        private IDepartmentDal departmentDal;

        public DepartmentService(IDepartmentDal departmentDal)
        {
            this.departmentDal = departmentDal;
        }

        public void Add(Department department)
        {
            this.departmentDal.Add(department);
        }

        public void Delete(Department department)
        {
            this.departmentDal.Delete(department);
        }

        public Department GetDepartmentById(int id)
        {
            return this.departmentDal.Get(x => x.DepartmentId == id);
        }

        public List<Department> GetDepartments()
        {
            return this.departmentDal.GetList();
        }

        public void Update(Department department)
        {
            this.departmentDal.Update(department);
        }
    }
}
