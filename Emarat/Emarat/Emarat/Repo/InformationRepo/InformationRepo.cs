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

namespace Emarat.Repo.InformationRepo
{
    public class InformationRepo : IInformationRepo
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public InformationRepo(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> AddInformationAsync(InformationVM information)
        {
            try
            {
                
                var data = mapper.Map<Information>(information);
                await db.Information.AddAsync(data);
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

        public async Task<bool> DeleteInformationAsync(int id)
        {
            try
            {
                var data = await db.Information.FindAsync(id);
                db.Information.Remove(data);
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

        public async Task<bool> EditInformationAsync(InformationVM information)
        {
            try
            {
                var data = mapper.Map<Information>(information);
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

        public async Task<List<InformationVM>> GetAllInformationAsync()
        {
            var data = await db.Information.Select(a => new InformationVM
            {
                Id = a.Id,
                Email = a.Email,
                LocationAr = a.LocationAr,
                LocationEn = a.LocationEn,
                LocationLink = a.LocationLink,
                Phone1 = a.Phone1,
                Phone2 = a.Phone2
            }).ToListAsync();
            return data;
        }

        public async Task<InformationVM> GetByIdInformationAsync(int id)
        {
            var data = await db.Information.Where(a => id == a.Id).Select(a => new InformationVM
            {
                Id = a.Id,
                Email = a.Email,
                LocationAr = a.LocationAr,
                LocationEn = a.LocationEn,
                LocationLink = a.LocationLink,
                Phone1 = a.Phone1,
                Phone2 = a.Phone2
            }).FirstOrDefaultAsync();
            return data;
        }
    }
}
