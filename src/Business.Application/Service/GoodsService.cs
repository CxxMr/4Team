using Business.Dto;
using Business.Helper;
using Business.Helper.Enum;
using Business.IService;
using Business.Model.Goods;
using Business.Model.RBAC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Service
{
    public class GoodsService : CrudAppService<GoodsModel, GoodsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>, IGoodsService
    {
        private readonly IRepository<GoodsModel, Guid> myRoleModels;

        public GoodsService(IRepository<GoodsModel, Guid>  _myRoleModels) : base(_myRoleModels) 
        {
            myRoleModels = _myRoleModels;
        }
     

        public Task<IEnumerator<GoodsDto>> PageIndex(int PageIndex, int PageSize, string Name)
        {
            throw new NotImplementedException();
        }








    }
}

