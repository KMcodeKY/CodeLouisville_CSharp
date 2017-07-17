using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Affiliation
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        public string Organization { get; set; }
        public string Website { get; set; }
        [Required]
        [Display(Name = "Affiliation Type")]
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}