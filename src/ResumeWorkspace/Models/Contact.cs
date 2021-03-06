﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int PositionId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Position Position { get; set; }
    }
}