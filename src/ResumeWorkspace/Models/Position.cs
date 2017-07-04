using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Position
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public ICollection<Accomplishment> Accomplishments { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}