using AutoMapper;
using DAL.Contanier;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.JopRepo
{
    public class JopRepo : IJopRepo
    {
        private readonly ApplacationDbContext db;
        private readonly IMapper mapper;

        public JopRepo(ApplacationDbContext db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public bool AddJop(JopVM jop)
        {
            try
            {
                var data = mapper.Map<Jop>(jop);
                db.Jops.Add(data);
                int res = db.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
           
        }

        public bool DeleteJop(int Id)
        {
            try
            {
                var data = db.Jops.Find(Id);
                db.Jops.Remove(data);
                int res = db.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
           
        }

        public bool EditJop(JopVM jop)
        {
            try
            {
                var data = mapper.Map<Jop>(jop);
                db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                int res = db.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {

                return false;
            }
         

        }

        public IQueryable<JopVM> GetAllJop()
        {
            
           IQueryable<JopVM> data =  db.Jops.Select(a => new JopVM { JopId = a.JopId, JopName = a.JopName });
            return data;
        }

        public JopVM GetJopById(int Id)
        {
            JopVM data = db.Jops.Where(a => a.JopId == Id).Select(a => new JopVM { JopId = a.JopId, JopName = a.JopName }).FirstOrDefault();
            return data;
        }
    }
}
