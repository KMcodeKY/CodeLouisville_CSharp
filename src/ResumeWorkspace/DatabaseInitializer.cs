﻿using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResumeWorkspace
{
    internal class DatabaseInitializer
        : DropCreateDatabaseAlways<Context>
    {

        protected override void Seed(Context context)
        {
            var person1 = new Person()
            {
                Name = "Alex Moore"
            };

            var employment1 = new Employment()
            {
                StartDate = new DateTime(2000, 1, 1),
                EndDate = new DateTime(2004, 6, 1),
                Employer = "ABC Marketing",
                Description = "Marketing company providing custom media solutions inlcuding print, web, media, etc.",
                Website = "www.abcmarketing.com",
                Address = "1234 A Street",
                City = "Louisville",
                State = "KY",
                Zip = "12345"
            };
            var employment2 = new Employment()
            {
                StartDate = new DateTime(2004, 6, 2),
                Employer = "XYZ Marketing",
                Description = "Marketing company providing custom media solutions inlcuding print, web, media, etc.",
                Website = "www.xyzmarketing.com",
                Address = "1234 B Street",
                City = "Louisville",
                State = "KY",
                Zip = "12345"
            };
            var position1 = new Position()
            {
                StartDate = new DateTime(2000, 1, 1),
                EndDate = new DateTime(2002, 1, 1),
                Title = "Front End Developer"
            };
            var position2 = new Position()
            {
                StartDate = new DateTime(2002, 1, 2),
                EndDate = new DateTime(2004, 6, 1),
                Title = ".NET Developer"
            };
            var position3 = new Position()
            {
                StartDate = new DateTime(2004, 6, 2),
                EndDate = new DateTime(2006, 6, 2),
                Title = "Front End Lead Developer"
            };
            var position4 = new Position()
            {
                StartDate = new DateTime(2006, 6, 2),
                Title = ".NET Lead Developer"
            };
            var accomplishment1 = new Accomplishment()
            {
                Description = "Project 1........"
            };
            var accomplishment2 = new Accomplishment()
            {
                Description = "Project 2........"
            };
            var accomplishment3 = new Accomplishment()
            {
                Description = "Project 3........"
            };
            var accomplishment4 = new Accomplishment()
            {
                Description = "Project 4........"
            };
            var accomplishment5 = new Accomplishment()
            {
                Description = "Project 5........"
            };
            var accomplishment6 = new Accomplishment()
            {
                Description = "Project 6........"
            };
            var accomplishment7 = new Accomplishment()
            {
                Description = "Project 7........"
            };
            var accomplishment8 = new Accomplishment()
            {
                Description = "Project 8........"
            };
            var contact1 = new Contact()
            {
                Name = "A Smith",
                Title = "System 1 Manager",
                Email = "ASMITH@ABC.COM",
                Phone = "111-111-1111 extension 111"
            };
            var contact2 = new Contact()
            {
                Name = "B Smith",
                Title = "System 2 Manager",
                Email = "BSMITH@ABC.COM",
                Phone = "222-222-2222 extension 222"
            };
            var contact3 = new Contact()
            {
                Name = "C Jones",
                Title = "System X Manager",
                Email = "CJONES@XYZ.COM",
                Phone = "777-777-7777 extension 777"
            };
            var contact4 = new Contact()
            {
                Name = "D Jones",
                Title = "System Y Manager",
                Email = "DJONES@XYZ.COM",
                Phone = "888-888-8888 extension 888"
            };

            position1.AddAccomplishment(accomplishment1);
            position1.AddAccomplishment(accomplishment2);
            position2.AddAccomplishment(accomplishment3);
            position2.AddAccomplishment(accomplishment4);
            position3.AddAccomplishment(accomplishment5);
            position3.AddAccomplishment(accomplishment6);
            position4.AddAccomplishment(accomplishment7);
            position4.AddAccomplishment(accomplishment8);

            position1.AddContact(contact1);
            position2.AddContact(contact2);
            position3.AddContact(contact3);
            position4.AddContact(contact4);

            employment1.AddPosition(position1);
            employment1.AddPosition(position2);
            employment2.AddPosition(position3);
            employment2.AddPosition(position4);

            person1.AddEmployment(employment1);
            person1.AddEmployment(employment2);

            //context.Employment.Add(employment1);
            //context.Employment.Add(employment2);

            var education1 = new Education()
            {
                StartDate = new DateTime(1995, 8, 20),
                EndDate = new DateTime(1999, 12, 15),
                Institution = "University of ABC",
                Website = "www.abc.edu",
                Address = "1234 C Street",
                City = "Louisville",
                State = "KY",
                Zip = "12345",
                Degree = "Bachelors in Computer Science",
                GPA = 3.50,
                Accomplishments = "Clubs, Awards, etc..."
            };
            var education2 = new Education()
            {
                StartDate = new DateTime(2000, 1, 1),
                EndDate = new DateTime(2003, 5, 15),
                Institution = "University of ABC",
                Website = "www.abc.edu",
                Address = "1234 C Street",
                City = "Louisville",
                State = "KY",
                Zip = "12345",
                Degree = "Masters in Computer Science",
                GPA = 3.70,
                Accomplishments = "Clubs, Awards, etc..."
            };

            person1.AddEducation(education1);
            person1.AddEducation(education2);

            //context.Education.Add(education1);
            //context.Education.Add(education2);

            var certification1 = new Certification()
            {
                CompletionDate = new DateTime(2005, 6, 1),
                Organization = "Project Management Institute",
                Website = "www.pmi.org/certifications",
                Type = "Project Management Professional",
                Description = "Project management competencies in serving as project manager, leading and directing projects"
            };
            var certification2 = new Certification()
            {
                CompletionDate = new DateTime(2004, 6, 1),
                Organization = "CompTIA",
                Website = "www.certification.comptia.org",
                Type = "CompTIA A+",
                Description = "Foundational IT skills across a variety of devices and operating systems"
            };

            person1.AddCertification(certification1);
            person1.AddCertification(certification2);

            //context.Certification.Add(certification1);
            //context.Certification.Add(certification2);

            var skill1 = new Skill()
            {
                Type = "Front End Development",
                Description = "HTML, CSS, Javascript....."
            };

            var skill2 = new Skill()
            {
                Type = "Back End Development",
                Description = "C#/.Net Framework"
            };

            person1.AddSkill(skill1);
            person1.AddSkill(skill2);

            //context.Skill.Add(skill1);
            //context.Skill.Add(skill2);

            var affiliation1 = new Affiliation()
            {
                StartDate = new DateTime(2000, 2, 1),
                Organization = "Association of Information Technology Professionals",
                Website = "www.aitp.org",
                Type = "Member",
                Description = "Chapter meetings, industry trends, ..."
            };

            var affiliation2 = new Affiliation()
            {
                StartDate = new DateTime(2004, 9, 1),
                Organization = "Louisville Public Library",
                Website = "www.lfpl.org",
                Type = "Volunteer",
                Description = "Student tutor"
            };

            person1.AddAffiliation(affiliation1);
            person1.AddAffiliation(affiliation2);

            //context.Affiliation.Add(affiliation1);
            //context.Affiliation.Add(affiliation2);

            context.Person.Add(person1);

            context.SaveChanges();

        }
    }
}
