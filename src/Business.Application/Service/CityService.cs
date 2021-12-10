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
    public class CityService : CrudAppService<CityModel, CityDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCityDto>, ICityService
    {
        public CityService(IRepository<CityModel, Guid> myRoleModels) : base(myRoleModels) { }
    }
}
