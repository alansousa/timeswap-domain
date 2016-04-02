using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSwap.Domain.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public int FaseId { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public int? AssignmentType { get; set; }
        public int? Line { get; set; }
        public int? DependecyLine { get; set; }
        public double? Duration { get; set; }
        public double? Percentage { get; set; }
        public DateTime? RealStart { get; set; }
        public DateTime? RealEnd { get; set; }
        public DateTime BaseStart { get; set; }
        public DateTime BaseEnd { get; set; }

        public virtual Fase Fase { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
