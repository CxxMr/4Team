
using Business.Dto;
using Business.Helper.Enum;
using Business.IService;
using Business.Model.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Service
{

    public class MyUserService: CrudAppService<MyUserModel, MyUserDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateMyUserDto>, IMyUserService
    {

        private readonly IRepository<MyUserModel, Guid> userModels;

        public MyUserService(IRepository<MyUserModel,Guid> _userModels) : base(_userModels) 
        {
            userModels = _userModels;
        }

        
    }
}
