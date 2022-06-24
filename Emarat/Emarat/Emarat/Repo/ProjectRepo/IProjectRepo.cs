using Emarat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.ProjectRepo
{
   public  interface IProjectRepo
    {
        public Task<bool> AddProjectAsync(ProjectVM project);
        public Task<bool> EditProjectAsync(ProjectVM project);
        public Task<bool> DeleteProjectAsync(int id);
        public Task<ProjectVM> GetByIdProjectAsync(int id);
        public Task<List<ProjectVM>> GetAllProjectAsync();
    }
}
