using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int EmploymentId { get; set; }
        public int PositionId { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Employment Employment { get; set; }
        public virtual Position Position { get; set; }
    }
}