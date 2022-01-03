using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.JopRepo
{
    public interface IJopRepo
    {
        bool AddJop(JopVM jop);
        bool EditJop(JopVM jop);
        bool DeleteJop(int Id);
        JopVM GetJopById(int Id);
        List<JopVM> GetAllJop();
    }
}
