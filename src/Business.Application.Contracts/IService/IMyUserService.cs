﻿using Business.Dto;
using Business.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.IService
{
   public  interface IMyUserService:ICrudAppService<MyUserDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateMyUserDto>
    {
     
    }
}
