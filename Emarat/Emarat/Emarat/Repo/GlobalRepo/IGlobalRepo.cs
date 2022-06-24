using Emarat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.GlobalRepo
{
   public  interface IGlobalRepo
    {
        public Task<bool> AddGlobalAsync(GlobalVM global);
        public Task<bool> EditGlobalAsync(GlobalVM global);
        public Task<bool> DeleteGlobalAsync(int id);
        public Task<GlobalVM> GetByIdGlobalAsync(int id);
        public Task<List<GlobalVM>> GetAllGlobalAsync();
    }
}
