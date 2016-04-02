using System.Collections.Generic;
using TimeSwap.Domain.Entities;

namespace TimeSwap.Domain.ProjectFile
{
    interface IImportProjectFile
    {
        void SetFile(byte[] file, string path);

        Project GetFullProject();

        Project GetProject();
        IList<Fase> GetFases();
        IList<Assignment> GetAssignments();
    }
}
