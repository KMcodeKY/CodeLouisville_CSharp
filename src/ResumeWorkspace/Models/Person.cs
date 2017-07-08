using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Person
    {
        public Person()
        {
            EmploymentHistory = new List<Employment>();
            EducationHistory = new List<Education>();
            CertificationHistory = new List<Certification>();
            SkillHistory = new List<Skill>();
            AffiliationHistory = new List<Affiliation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employment> EmploymentHistory { get; set; }
        public virtual ICollection<Education> EducationHistory { get; set; }
        public virtual ICollection<Certification> CertificationHistory { get; set; }
        public virtual ICollection<Skill> SkillHistory { get; set; }
        public virtual ICollection<Affiliation> AffiliationHistory { get; set; }

        public void AddEmployment(Employment employment)
        {
            EmploymentHistory.Add(employment);
        }

        public void AddEducation(Education education)
        {
            EducationHistory.Add(education);
        }

        public void AddCertification(Certification certification)
        {
            CertificationHistory.Add(certification);
        }

        public void AddSkill(Skill skill)
        {
            SkillHistory.Add(skill);
        }

        public void AddAffiliation(Affiliation affiliation)
        {
            AffiliationHistory.Add(affiliation);
        }

    }
}