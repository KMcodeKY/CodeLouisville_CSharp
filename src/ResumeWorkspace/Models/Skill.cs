using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}