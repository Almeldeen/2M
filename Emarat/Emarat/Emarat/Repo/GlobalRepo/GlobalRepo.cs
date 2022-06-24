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

namespace Emarat.Repo.GlobalRepo
{
    
    public class GlobalRepo : IGlobalRepo
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public GlobalRepo(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> AddGlobalAsync(GlobalVM global)
        {
            try
            {
                if (global.ImageArvM != null)
                {
                    var FileNameAr = await SaveFile.SaveFileAsync(global.ImageArvM, FilePath.ImageGlobal);
                    var pathAr = httpContextAccessor.HttpContext.Request.Host.Value + "/IMGsGlobal/" + FileNameAr;
                    global.ImageAr = pathAr;
                   
                }if (global.ImageEnVM != null)
                {
                    var FileNameEn = await SaveFile.SaveFileAsync(global.ImageArvM, FilePath.ImageGlobal);
                    var pathEn = httpContextAccessor.HttpContext.Request.Host.Value + "/IMGsGlobal/" + FileNameEn;
                    global.ImageAr = pathEn;
                }
                
                var data = mapper.Map<Global>(global);
                await db.Globals.AddAsync(data);
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

        public async Task<bool> DeleteGlobalAsync(int id)
        {
            try
            {
                var data = await db.Globals.FindAsync(id);
                db.Globals.Remove(data);
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

        public async Task<bool> EditGlobalAsync(GlobalVM global)
        {
            try
            {
             
                var data = mapper.Map<Global>(global);
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

        public async Task<List<GlobalVM>> GetAllGlobalAsync()
        {
            var data = await db.Globals.Select(a => new GlobalVM
            {
               Id = a.Id ,
                DetailsAr = a.DetailsAr ,
                DetailsEn =a.DetailsEn ,
                ImageAr = a.ImageAr , 
                ImageEn = a.ImageEn ,
                Name = a.Name , 
                TitelAr = a.TitelAr , 
                TitelEn = a.TitelEn   

            }).ToListAsync();
            return data;
        }

        public async Task<GlobalVM> GetByIdGlobalAsync(int id)
        {
            var data = await db.Globals.Where(a=> id == a.Id).Select(a => new GlobalVM
            {
                Id = a.Id,
                DetailsAr = a.DetailsAr,
                DetailsEn = a.DetailsEn,
                ImageAr = a.ImageAr,
                ImageEn = a.ImageEn,
                Name = a.Name,
                TitelAr = a.TitelAr,
                TitelEn = a.TitelEn

            }).FirstOrDefaultAsync();
            return data;
        }
    }
}
