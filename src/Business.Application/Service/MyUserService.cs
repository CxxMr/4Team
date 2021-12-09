
using Business.Dto;
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

    public class MyUserService: CrudAppService<MyUserModel, MyUserDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateMyUserDto>,IMyUserService
    {
        public MyUserService(IRepository<MyUserModel,Guid> userModels) : base(userModels) { }

    }
}
