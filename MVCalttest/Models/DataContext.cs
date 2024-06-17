using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { }

        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<RegressResult> RegressResults { get; set; }
        public virtual DbSet<RegressTemplate> RegressTemplates { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<TestDoc> TestDocs { get; set; }
        public virtual DbSet<TestPlan> TestPlans { get; set; }
        public virtual DbSet<TestPlanDoc> TestPlanDocs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
        {
            builder.UseMySQL("Server=localhost;Database=AltTestDB;UserId=root;Password=kborisova_DB01;");
        }
    }
}
