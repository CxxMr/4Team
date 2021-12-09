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
    public  class MyUserRoleService : CrudAppService<MyUserRoleModel, MyUserRoleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMyUserRoleDto>, IMyUserRoleService
    {
        public MyUserRoleService(IRepository<MyUserRoleModel, Guid> userModels) : base(userModels) { }
    }
}
