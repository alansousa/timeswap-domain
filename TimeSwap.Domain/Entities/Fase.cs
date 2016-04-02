using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSwap.Domain.Entities
{
    public class Fase
    {
        public int FaseId { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<Assignment> Assignments{ get; set; }
    }
}
