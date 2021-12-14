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
    public class GoodsService : CrudAppService<GoodsModel, GoodsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>, IGoodsService
    {
        private readonly IRepository<GoodsModel, Guid> myRoleModels;

        public GoodsService(IRepository<GoodsModel, Guid>  _myRoleModels) : base(_myRoleModels) 
        {
            myRoleModels = _myRoleModels;
        }
        //public async Task<IEnumerator<GoodsDto>> PageIndex(iNt PageIndex, int PageSize, string Name)
        //{
        //    //var Goods = await myRoleModels.GetListAsync();
            
        //    //if(!string.IsNullOrWhiteSpace(Name))
        //    //{
        //    //    Goods = Goods.Where(x => x.GoodsName.Contains(Name)).ToList();
        //    //}
        //    //var total = Goods.Count();
        //    //Goods = Goods.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
         
        //}
        public Task<IEnumerator<GoodsDto>> PageIndex(int PageIndex, int PageSize, string Name)
        {
            throw new NotImplementedException();
        }
    }
}

