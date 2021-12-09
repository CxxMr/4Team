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
    public   class MyRoleService: CrudAppService<MyRoleModel,MyRoleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMyRoleDto>,IMyRoleService
    {
        public MyRoleService(IRepository<MyRoleModel, Guid> myRoleModels) : base(myRoleModels) { }
    }
}
