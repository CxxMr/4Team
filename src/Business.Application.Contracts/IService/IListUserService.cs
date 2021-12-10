using Business.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Business.Helper.Enum;

namespace Business.IService
{
    public interface IListUserService : IApplicationService
    {
        //定义一个方法
           Task<ResulstHelper<PagedResultDto<ListUserDto>>>  PagedResultDto(int PageIndex, int PageSize);
    }
}
    
