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

namespace Emarat.Repo.ProjectRepo
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly AppDbContext db;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ProjectRepo(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.db = db;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> AddProjectAsync(ProjectVM Project)
        {
            try
            {

                var data = mapper.Map<Project>(Project);
                await db.Projects.AddAsync(data);
                var result = await db.SaveChangesAsync();
                if (result <= 0)
                {
                    return false;
                }
                if(Project.ProjectImage.Count>0)
                {
                    Project.ProjectImagePath = new List<string>();
                    foreach (var item in Project.ProjectImage)
                    {
                        var FileName = SaveFile.SaveFileAsync(item, FilePath.ImageProject);
                        var path = httpContextAccessor.HttpContext.Request.Host.Value + "/IMGsProject/" + FileName;
                        Project.ProjectImagePath.Add(path);
                    }
                    if (Project.ProjectImagePath.Count > 0)
                    {
                        List<ProjectImages> projectImages = new List<ProjectImages>();
                        foreach (var item in Project.ProjectImagePath)
                        {
                            projectImages.Add( new ProjectImages { Image = item , ProjectId = data.Id });
                        }
                        return true;
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProjectAsync(int id)
        {
            try
            {
                var data = await db.Projects.FindAsync(id);
                db.Projects.Remove(data);
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

        public async Task<bool> EditProjectAsync(ProjectVM project)
        {
            try
            {
                var data = mapper.Map<Project>(project);
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

        public async Task<List<ProjectVM>> GetAllProjectAsync()
        {
            var data = await db.Projects.Select(a => new ProjectVM
            {
                Id=a.Id ,
                NameAr =a.NameAr ,
                NameEn = a.NameEn ,
                DateAr=a.DateAr ,
                DateEn = a.DateEn ,
                DetailsAr =a.DetailsAr ,
                DetailsEn=a.DetailsEn ,
                LocationAr =a.LocationAr ,
                LocationEn =a.LocationEn ,
                ProjectImagePath = a.ProjectImages.Select(x=> x.Image).ToList(), 
                ServiceDetailsID=a.ServiceDetailsID
            }).ToListAsync();
            return data;
        }

        public async Task<ProjectVM> GetByIdProjectAsync(int id)
        {
            var data = await db.Projects.Where(a => id == a.Id).Select(a => new ProjectVM
            {
                Id = a.Id,
                NameAr = a.NameAr,
                NameEn = a.NameEn,
                DateAr = a.DateAr,
                DateEn = a.DateEn,
                DetailsAr = a.DetailsAr,
                DetailsEn = a.DetailsEn,
                LocationAr = a.LocationAr,
                LocationEn = a.LocationEn,
                ProjectImagePath = a.ProjectImages.Select(x => x.Image).ToList(),
                ServiceDetailsID = a.ServiceDetailsID
            }).FirstOrDefaultAsync();
            return data;
        }
    }
}
