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

        //Get From ID

        public Employment GetEmployment(int id)
        {
            return (from x in Employment where x.Id == id select x).First();
        }

        public Position GetPosition(int id)
        {
            return (from x in Position where x.Id == id select x).First();
        }

        public Accomplishment GetAccomplishment(int id)
        {
            return (from x in Accomplishment where x.Id == id select x).First();
        }

        public Contact GetContact(int id)
        {
            return (from x in Contact where x.Id == id select x).First();
        }

        public Affiliation GetAffiliation(int id)
        {
            return (from x in Affiliation where x.Id == id select x).First();
        }

        public Certification GetCertification(int id)
        {
            return (from x in Certification where x.Id == id select x).First();
        }

        public Education GetEducation(int id)
        {
            return (from x in Education where x.Id == id select x).First();
        }

        public Skill GetSkill(int id)
        {
            return (from x in Skill where x.Id == id select x).First();
        }

        //Add

        public void AddEmployment(Employment employment)
        {
            Employment.Add(employment);
            this.SaveChanges();
        }

        public void AddPosition(Position position)
        {
            Position.Add(position);
            this.SaveChanges();
        }

        public void AddAccomplishment(Accomplishment accomplishment)
        {
            Accomplishment.Add(accomplishment);
            this.SaveChanges();
        }

        public void AddContact(Contact contact)
        {
            Contact.Add(contact);
            this.SaveChanges();
        }

        public void AddAffiliation(Affiliation affiliation)
        {
            Affiliation.Add(affiliation);
            this.SaveChanges();
        }

        public void AddCertification(Certification certification)
        {
            Certification.Add(certification);
            this.SaveChanges();
        }

        public void AddEducation(Education education)
        {
            Education.Add(education);
            this.SaveChanges();
        }

        public void AddSkill(Skill skill)
        {
            Skill.Add(skill);
            this.SaveChanges();
        }

        //Edit

        public void EditEmployment(Employment employment)
        {
            this.Entry(employment).State = EntityState.Modified;
            this.SaveChanges();
        }

        public void EditPosition(Position position)
        {
            this.Entry(position).State = EntityState.Modified;

            foreach (var acc in position.Accomplishments)
            {
                this.Entry(acc).State = EntityState.Modified;
            }

            foreach (var con in position.Contacts)
            {
                this.Entry(con).State = EntityState.Modified;
            }

            this.SaveChanges();
        }

        public void EditAffiliation(Affiliation affiliation)
        {
            this.Entry(affiliation).State = EntityState.Modified;
            this.SaveChanges();
        }

        public void EditCertification(Certification certification)
        {
            this.Entry(certification).State = EntityState.Modified;
            this.SaveChanges();
        }

        public void EditEducation(Education education)
        {
            this.Entry(education).State = EntityState.Modified;
            this.SaveChanges();
        }

        public void EditSkill(Skill skill)
        {
            this.Entry(skill).State = EntityState.Modified;
            this.SaveChanges();
        }

        //Delete

        public void DeleteEmployment(Employment employment)
        {
            this.Entry(employment).State = EntityState.Deleted;
            this.SaveChanges();
        }

        //Error in deleting position//

        public void DeletePosition(Position position)
        {
            foreach (var acc in position.Accomplishments)
            {
                this.Entry(acc).State = EntityState.Deleted;
            }

            foreach (var con in position.Contacts)
            {
                this.Entry(con).State = EntityState.Deleted;
            }

            this.Entry(position).State = EntityState.Deleted;

            this.SaveChanges();
        }

        public void DeleteAccomplishment(Accomplishment accomplishment)
        {
            this.Entry(accomplishment).State = EntityState.Deleted;
            this.SaveChanges();
        }

        public void DeleteContact(Contact contact)
        {
            this.Entry(contact).State = EntityState.Deleted;
            this.SaveChanges();
        }

        public void DeleteAffiliation(Affiliation affiliation)
        {
            this.Entry(affiliation).State = EntityState.Deleted;
            this.SaveChanges();
        }

        public void DeleteCertification(Certification certification)
        {
            this.Entry(certification).State = EntityState.Deleted;
            this.SaveChanges();
        }

        public void DeleteEducation(Education education)
        {
            this.Entry(education).State = EntityState.Deleted;
            this.SaveChanges();
        }

        public void DeleteSkill(Skill skill)
        {
            this.Entry(skill).State = EntityState.Deleted;
            this.SaveChanges();
        }
    }
}