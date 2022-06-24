using DAL.Reposatiories.JopRepo;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.JopService
{
    public class JopService : IJopService
    {
        private readonly IJopRepo repo;

        public JopService(IJopRepo repo)
        {
            this.repo = repo;
        }
        public bool AddJop(JopVM jop)
        {
            return repo.AddJop(jop);
        }

        public bool DeleteJop(int Id)
        {
            return repo.DeleteJop(Id);
        }

        public bool EditJop(JopVM jop)
        {
            return repo.EditJop(jop);
        }

        public IQueryable<JopVM> GetAllJop()
        {
            return repo.GetAllJop();
        }

        public JopVM GetJopById(int Id)
        {
            return repo.GetJopById(Id);
        }
    }
}
