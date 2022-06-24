using Emarat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.InformationRepo
{
   public  interface IInformationRepo
    {
        public Task<bool> AddInformationAsync(InformationVM information);
        public Task<bool> EditInformationAsync(InformationVM information);
        public Task<bool> DeleteInformationAsync(int id);
        public Task<InformationVM> GetByIdInformationAsync(int id);
        public Task<List<InformationVM>> GetAllInformationAsync();
    }
}
