using System.Collections.Generic;

namespace TimeSwap.Domain.Entities
{
    public class Project
    {
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int ManagerId { get; set; }

        public virtual ICollection<Fase> Fases { get; set; }
        public virtual Resource Manager{ get; set; }
    }
}
