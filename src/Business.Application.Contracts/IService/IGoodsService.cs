using Business.Dto;
using Business.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.IService
{
    public interface IGoodsService : ICrudAppService<GoodsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>
    {

        public Task<IEnumerator<GoodsDto>> PageIndex(int  PageIndex,int PageSize,string Name);

    }
}
