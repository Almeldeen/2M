using AutoMapper;
using DAL.Container;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reprositry
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public UserRepo(ApplicationDbContext db , IMapper mapper )
        {
            this.db = db;
            this.mapper = mapper;
        }
        public bool AddUser(UserVM user)
        {
            try
            {
                var data = mapper.Map<User>(user);
                db.User.Add(data);
                var res = db.SaveChanges();
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

        public bool LogIn(UserVM user)
        {
            var data = db.User.Where(a => a.Email == user.Email && a.Password == user.Password).Any();
            return data;
        }
    }
}
