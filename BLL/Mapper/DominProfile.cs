using AutoMapper;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
   public class DominProfile : Profile
    {
        public DominProfile()
        {
            CreateMap<Jop, JopVM>();
            CreateMap<JopVM, Jop>();
            CreateMap<EmpVM, Employee>();
            CreateMap<Employee, EmpVM>();
            CreateMap<Accounts, AccVM>();
            CreateMap<AccVM,Accounts >();
            CreateMap<Suppliers,SupplierVM>();
            CreateMap<SupplierVM,Suppliers>();
            CreateMap<Attendance,AttendVM>();
            CreateMap<AttendVM,Attendance>();
            CreateMap<EmpExpensesVM, EmpExpenses>();
            CreateMap<EmpExpenses, EmpExpensesVM>();
            CreateMap<AccountOperations, AccOpVM>();
            CreateMap<AccOpVM, AccountOperations>();


        }
    }
}
