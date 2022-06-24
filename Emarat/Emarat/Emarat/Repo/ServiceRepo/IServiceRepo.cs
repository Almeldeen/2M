using Emarat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.ServiceRepo
{
    public interface IServicerepo
    {
        public Task<bool> AddServiceAsync(ServiceVM service);
        public Task<bool> EditServiceAsync(ServiceVM service);
        public Task<bool> DeleteServiceAsync(int id);
        public Task<ServiceVM> GetByIdServiceAsync(int id);
        public Task<List<ServiceVM>> GetAllServiceAsync();
    }
}
