using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSwap.Domain.Entities
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public int OcupationId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double? ValueOfHour { get; set; }

        public virtual Ocupation Ocupation { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ResourceAssignment> ResourceAssignments{ get; set; }
        public virtual ICollection<ResourceAbility> ResourceAbility { get; set; }

    }
}
