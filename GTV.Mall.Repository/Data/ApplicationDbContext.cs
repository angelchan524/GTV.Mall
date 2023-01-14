using GTV.Mall.Models;
using GTV.Mall.Models.DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Repository.Data
{
    //public class ApplicationDbContext : DbContext
    //{
    //    private readonly string _connectionString;

    //    public ApplicationDbContext(string connectionString)
    //    {
    //        _connectionString = connectionString;
    //    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(_connectionString);
    //    }

    //}

    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //public DbSet<Category> Categories { get; set; }

        public DbSet<Member> Member { get; set; }
    }
}
