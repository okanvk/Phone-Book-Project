using App.PhoneBook.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.PhoneBook.DataAccess.Concrete
{
    public class PhoneBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HHHH\SQLEXPRESS;Database=PhoneBook;Trusted_Connection=true",b => b.MigrationsAssembly("App.PhoneBook.DataAccess"));

            //   base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne(b => b.ParentEmployee).WithMany().HasForeignKey(b => b.ParentEmployeeId);
        }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
