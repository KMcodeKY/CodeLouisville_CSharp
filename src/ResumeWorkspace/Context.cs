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
        }
        
        public DbSet<Employment> Employment { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Accomplishment> Accomplishment { get; set; }
        public DbSet<Contact> Contact { get; set; }

        public DbSet<Education> Education { get; set; }
        public DbSet<Certification> Certification { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Affiliation> Affiliation { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}