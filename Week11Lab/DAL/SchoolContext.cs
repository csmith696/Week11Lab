using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week11Lab.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Week11Lab.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext") { }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
