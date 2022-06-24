using Emarat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.PartnerRepo
{
    public interface IPartnerRepo
    {
        public Task<bool> AddPartnerAsync(PartnerVM partner);
        public Task<bool> EditPartnerAsync(PartnerVM partner);
        public Task<bool> DeletePartnerAsync(int id);
        public Task<PartnerVM> GetByIdPartnerAsync(int id);
        public Task<List<PartnerVM>> GetAllPartnerAsync();
    }
}
