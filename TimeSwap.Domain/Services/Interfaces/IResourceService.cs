using System.Collections.Generic;
using TimeSwap.Domain.Entities;
using TimeSwap.Domain.Services.Interfaces.Common;

namespace TimeSwap.Domain.Services.Interfaces
{
    public interface IResourceService : ICommonService<Resource>
    {
        List<Ability> GetResourceAbilities(int resourceId);
        List<Assignment> GetResourceAssignments(int resourceId, string projectId = null);
    }
}
