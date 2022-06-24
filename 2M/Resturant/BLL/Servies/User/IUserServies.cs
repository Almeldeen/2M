using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servies
{
    public interface IUserServies
    {
        bool AddUser(UserVM user);
        bool LogIn(UserVM user);
    }
}
