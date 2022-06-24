using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reprositry
{
   public  interface IUserRepo
    {
        bool AddUser(UserVM user);
        bool LogIn(UserVM user);
    }
}
