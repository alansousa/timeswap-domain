using TimeSwap.Domain.Enums;

namespace TimeSwap.Domain.Entities
{
    public class ResourceAbility
    {
        public int AbilityId { get; set; }
        public int ResourceId { get; set; }
        public AbilityLevel Level { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
