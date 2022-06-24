using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contanier
{
  public class ApplacationDbContext : IdentityDbContext
    {
        public ApplacationDbContext(DbContextOptions<ApplacationDbContext> options) : base(options)
        {
        }
        public DbSet<Jop> Stages { get; set; }
        public DbSet<Jop> Jops { set; get; }
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Suppliers> Suppliers { set; get; }
        public DbSet<SupplierOperations> SupplierOperations { set; get; }
        public DbSet<Accounts> Accounts { set; get; }
        public DbSet<AccountOperations> AccountOperations { set; get; }
        public DbSet<EmpExpenses> EmpExpenses { set; get; }
        public DbSet<Attendance> Attendances { set; get; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
