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

namespace Emarat.Repo.PartnerRepo
{
    public class PartnerRepo : IPartnerRepo
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public PartnerRepo(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> AddPartnerAsync(PartnerVM partner)
        {
            try
            {
                var FileName = await SaveFile.SaveFileAsync(partner.LogoVM, FilePath.ImagePartner);
                var path = httpContextAccessor.HttpContext.Request.Host.Value + "/IMGsPartner/" + FileName;
               partner.Logo = path;
                var data = mapper.Map<Partener>(partner);
                await db.Parteners.AddAsync(data);
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

        public async Task<bool> DeletePartnerAsync(int id)
        {
            try
            {
                var data = await db.Parteners.FindAsync(id);
                db.Parteners.Remove(data);
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

        public async Task<bool> EditPartnerAsync(PartnerVM partner)
        {
            try
            {
                var data = mapper.Map<Partener>(partner);
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

        public async Task<List<PartnerVM>> GetAllPartnerAsync()
        {
            var data = await db.Parteners.Select(a => new PartnerVM
            {
                Id = a.Id,
                Logo = a.Logo,
                NameAn = a.NameAn,
                NameEr = a.NameEr
            }).ToListAsync();
            return data;
        }

        public async Task<PartnerVM> GetByIdPartnerAsync(int id)
        {
            var data = await db.Parteners.Where(a=> id==a.Id).Select(a => new PartnerVM
            {
                Id = a.Id,
                Logo = a.Logo,
                NameAn = a.NameAn,
                NameEr = a.NameEr
            }).FirstOrDefaultAsync();
            return data;
        }
    }
}
