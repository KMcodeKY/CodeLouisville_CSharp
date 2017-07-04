using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ResumeWorkspace
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<Employment> EmploymentWorkspace { get; set; }
        public DbSet<Education> EducationWorkspace { get; set; }
        public DbSet<Certification> CertificationWorkspace { get; set; }
        public DbSet<Skill> SkillWorkspace { get; set; }
        public DbSet<Affiliation> AffiliationWorkspace { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}