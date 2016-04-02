using System.Collections.Generic;
using TimeSwap.Domain.Entities;

namespace TimeSwap.Domain.Services.Interfaces
{
    interface IProjectService
    {
        void ImportProject(Project project, byte[] file);

        IList<Project> GetProjects();
        Resource GetManager(int resourceId);
        IList<Resource> GetResources(string projectId);
    }
}
