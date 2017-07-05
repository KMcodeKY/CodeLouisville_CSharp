using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Position
    {
        public Position()
        {
            Accomplishments = new List<Accomplishment>();
            Contacts = new List<Contact>();
        }

        public int Id { get; set; }
        public int EmploymentId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Accomplishment> Accomplishments { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual Employment Employment { get; set; }

        public void AddAccomplishment(Accomplishment accomplishment)
        {
            Accomplishments.Add(accomplishment);
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}