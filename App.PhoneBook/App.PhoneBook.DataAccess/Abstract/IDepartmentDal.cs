using App.PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        // we can use this interface to implement some stored procedure or direct sql querys or some custom operations
    }
}
