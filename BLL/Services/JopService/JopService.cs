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
            throw new NotImplementedException();
        }

        public bool EditJop(JopVM jop)
        {
            throw new NotImplementedException();
        }

        public List<JopVM> GetAllJop()
        {
            throw new NotImplementedException();
        }

        public JopVM GetJopById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
