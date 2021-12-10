﻿using Business.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.IService
{
    public interface IMyTreeService : ICrudAppService<MyTreeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMyTreeDto>
    {
        public Task<List<MyTreeDto>> GetTreeAsync(string guid);
    }
}