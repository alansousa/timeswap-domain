using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSwap.Domain.Entities
{
    public class AssignmentProgress
    {
        public int AssignmentProgressId { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public virtual ResourceAssignment ResourceAssignment { get; set; }
    }
}
