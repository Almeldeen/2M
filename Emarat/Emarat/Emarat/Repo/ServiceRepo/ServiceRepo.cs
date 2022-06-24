using AutoMapper;
using Emarat.Data;
using Emarat.Helper;
using Emarat.Models;
using Emarat.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Repo.ServiceRepo
{
    public class ServiceRepo : IServicerepo
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ServiceRepo(AppDbContext db , IMapper mapper , IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> AddServiceAsync(ServiceVM service)
        {
            try
            {
                if (service.ImageVM != null)
                {
                    var FileName = await SaveFile.SaveFileAsync(service.ImageVM, FilePath.ImageProject);
                    var path = httpContextAccessor.HttpContext.Request.Host.Value + "/IMGsProject/" + FileName;
                    service.Image = path;
                }
               
                var data = mapper.Map<Service>(service);
                await db.Services.AddAsync(data);
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

        public async Task<bool> DeleteServiceAsync(int id)
        {
            try
            {
                var data = await db.Services.FindAsync(id);
                db.Services.Remove(data);
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

        public async Task<bool> EditServiceAsync(ServiceVM service)
        {
            try
            {
                var data = mapper.Map<Service>(service);
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

        public async Task<List<ServiceVM>> GetAllServiceAsync()
        {
            var data = await db.Services.Select(a => new ServiceVM
            {
                Id = a.Id,
                NameEn = a.NameEn,
                NameAr = a.NameAr,
                Image = a.Image



            }).ToListAsync();
            return data;
        }

        public async Task<ServiceVM> GetByIdServiceAsync(int id)
        {
            var data = await db.Services.Where(a => id == a.Id).Select(a => new ServiceVM
            {
                Id = a.Id,
                NameAr = a.NameAr,
                NameEn = a.NameEn,
                Image = a.Image
            }).FirstOrDefaultAsync();
            return data;
        }
    }
}
