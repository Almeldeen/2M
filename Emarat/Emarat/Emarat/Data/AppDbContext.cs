using Emarat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Global> Globals { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Partener> Parteners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImages> ProjectImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceDetails> ServiceDetails { get; set; }

    }
}
