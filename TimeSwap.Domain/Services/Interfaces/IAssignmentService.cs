using System.Collections.Generic;
using TimeSwap.Domain.Entities;
using TimeSwap.Domain.Services.Interfaces.Common;

namespace TimeSwap.Domain.Services.Interfaces
{
    interface IAssignmentService : ICommonService<Assignment>
    {
        void AlocateResource(Assignment task, Resource resource);
        void AlocateResource(Assignment task, List<Resource> resource);

        Assignment GetAssignment(int taskId);
    }
}
