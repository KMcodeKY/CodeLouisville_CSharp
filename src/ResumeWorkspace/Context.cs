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
        public DbSet<Person> Person { get; set; }

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

        public Employment GetEmployment(int id)
        {
            return (from x in Employment where x.Id == id select x).First();
        }

        public void AddEmployment(Employment employment)
        {
            Employment.Add(employment);
            this.SaveChanges();
        }

        public void EditEmployment(Employment employment)
        {
            this.Entry(employment).State = EntityState.Modified;
            this.SaveChanges();
        }

        public void DeleteEmployment(Employment employment)
        {
            this.Entry(employment).State = EntityState.Deleted;
            this.SaveChanges();
        }
    }
}