using DAL.Reprositry;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servies
{
    public class UserServies : IUserServies
    {
        private readonly IUserRepo repo;

        public UserServies( IUserRepo repo )
        {
            this.repo = repo;
        }
       

        public bool AddUser(UserVM user)
        {
            return repo.AddUser(user);
        }

        public bool LogIn(UserVM user)
        {
            return repo.LogIn(user);

        }


    }
}
