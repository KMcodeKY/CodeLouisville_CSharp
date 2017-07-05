using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWorkspace.Models
{
    public class Accomplishment
    {
        public int Id { get; set; }
        public int PositionId { get; set; }

        public string Description { get; set; }

        public virtual Position Position { get; set; }
    }
}