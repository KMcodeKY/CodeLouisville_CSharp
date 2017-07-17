using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "Skill")]
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}