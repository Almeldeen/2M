using AutoMapper;
using Emarat.Data;
using Emarat.Models;
using Emarat.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.ServiceDetailsRepo
{
    public class ServiceDetailsRepo : IServiceDetailsRepo
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ServiceDetailsRepo(AppDbContext db , IMapper mapper , IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> AddServiceDetailsAsync(ServiceDetailsVM servicedetails)
        {
            try
            {
                
                var data = mapper.Map<ServiceDetails>(servicedetails);
                await db.ServiceDetails.AddAsync(data);
                var result = await db.SaveChangesAsync();
                if (result > 0)
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

        public async Task<bool> DeleteServiceDetailsAsync(int id)
        {
            try
            {
                var data = await db.ServiceDetails.FindAsync(id);
                db.ServiceDetails.Remove(data);
                int result = await db.SaveChangesAsync();
                if (result > 0)
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

        public async Task<bool> EditServiceDetailsAsync(ServiceDetailsVM servicedetails)
        {
            try
            {
                var data = mapper.Map<ServiceDetails>(servicedetails);
                db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                int result = await db.SaveChangesAsync();
                if (result > 0)
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

        public async Task<List<ServiceDetailsVM>> GetAllServiceDetailsAsync()
        {
            var data = await db.ServiceDetails.Select(a => new ServiceDetailsVM
            {
                Id = a.Id,
                NameAr = a.NameAr,
                NameEn = a.NameEn,
                ServiceId = a.ServiceId,

            }).ToListAsync();
            return data;
        }

        public async Task<ServiceDetailsVM> GetByIdServiceDetailsAsync(int id)
        {
            var data = await db.ServiceDetails.Where(a => a.Id == id).Select(a => new ServiceDetailsVM
            {
                Id = a.Id,
                NameAr = a.NameAr,
                NameEn = a.NameEn,
                ServiceId = a.ServiceId
            }).FirstOrDefaultAsync();
            return data;
        }
    }
}
