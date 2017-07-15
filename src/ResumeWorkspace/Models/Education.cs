using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Education
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public string Institution { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Degree { get; set; }
        public double GPA { get; set; }
        public string Accomplishments { get; set; }

        public virtual Person Person { get; set; }
    }
}