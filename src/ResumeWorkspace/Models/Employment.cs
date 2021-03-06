﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ResumeWorkspace.Models
{
    public class Employment
    {
        public Employment()
        {
            Positions = new List<Position>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        public string Employer { get; set; }
        [Display(Name = "Employer Description")]
        public string Description { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

        public virtual Person Person { get; set; }

        public void AddPosition(Position position)
        {
            Positions.Add(position);
        }
    }
}