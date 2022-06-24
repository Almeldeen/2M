using AutoMapper;
using Emarat.Models;
using Emarat.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Mapper
{
    public class DomaimProfile : Profile
    {
        public DomaimProfile()
        {
            CreateMap<ServiceVM, Service>();
            CreateMap<Service, ServiceVM>();
            CreateMap<ServiceDetails, ServiceDetailsVM>();
            CreateMap<ServiceDetailsVM, ServiceDetails>();
            CreateMap<ProjectVM, Project>();
            CreateMap<Project, ProjectVM>();
        }
    }
}
