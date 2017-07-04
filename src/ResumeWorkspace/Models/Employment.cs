using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Employment
    {
        public Employment()
        {
            Positions = new List<Position>();
        }

        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public string Employer { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

        public void AddPosition(Position position)
        {
            Positions.Add(position);
        }
    }
}