using EntityFramworkCore.Configrations;
using EntityFramworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkCore
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)=>
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCore;Integrated Security=True");

        public DbSet<Employee> Employees { get; set; }


        // Configration Using seprate file BlogEntityTypeConfigration
        protected override void OnModelCreation(ModelBuilder _modelBuilder)   //instance from ModelBuilder
        { 
            new BlogEntityTypeConfigration().configure(_modelBuilder.Entity<Blog>());    // Apply seprate configrations
        } 

        public DbSet<Blog> Blogs { get; set; }
    }
}
