using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSwap.Domain.Entities
{
    public class ResourceAssignment
    {
        public int AssigmentId { get; set; }
        public int ResourceId { get; set; }

        public int Status { get; set; }

        public virtual Resource Resource { get; set; }
        public virtual Assignment Assigment { get; set; }
        public virtual AssignmentProgress AssignmentProgress { get; set; }
    }
}
