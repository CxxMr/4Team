using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class CategoryDto : AuditedEntityDto<Guid>
    {
        public string CategoryName { get; set; } //种类
    }
}
