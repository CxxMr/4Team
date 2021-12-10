using Business.Dto;
using Business.IService;
using Business.Model.Goods;
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
    public class SpecificationService : CrudAppService<SpecificationModel, SpecificationDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSpecificationDto>, ISpecificationService
    {
        public SpecificationService(IRepository<SpecificationModel, Guid> myRoleModels) : base(myRoleModels) { }
    }
}
