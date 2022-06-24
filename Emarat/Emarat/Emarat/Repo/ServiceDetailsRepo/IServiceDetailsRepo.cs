using Emarat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.ServiceDetailsRepo
{
   public  interface IServiceDetailsRepo
    {
        public Task<bool> AddServiceDetailsAsync(ServiceDetailsVM servicedetails);
        public Task<bool> EditServiceDetailsAsync(ServiceDetailsVM servicedetails);
        public Task<bool> DeleteServiceDetailsAsync(int id);
        public Task<ServiceDetailsVM> GetByIdServiceDetailsAsync(int id);
        public Task<List<ServiceDetailsVM>> GetAllServiceDetailsAsync();
    }
}
