﻿using Business.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.IService
{
    public interface IMyUserRoleService : ICrudAppService<MyUserRoleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMyUserRoleDto>
    {

    }
}
