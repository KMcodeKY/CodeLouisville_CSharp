﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Certification
    {
        public int Id { get; set; }

        public DateTime CompletionDate { get; set; }
        public string Organization { get; set; }
        public string Website { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}