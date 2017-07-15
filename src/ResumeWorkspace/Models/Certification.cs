using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public DateTime? CompletionDate { get; set; }
        [Required]
        public string Organization { get; set; }
        public string Website { get; set; }
        [Required]
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}