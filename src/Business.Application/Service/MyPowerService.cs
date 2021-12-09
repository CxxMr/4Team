using Business.Dto;
using Business.IService;
using Business.Model.RBAC;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Service
{
   public  class MyPowerService : CrudAppService<MyPowerModel,MyPowerDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateMyPowerDto>,IMyPowerService
    {
        public MyPowerService(IRepository<MyPowerModel, Guid> powerModels) : base(powerModels) { }
    }
    
}
