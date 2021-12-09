using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
    public  class MyPowerDto : AuditedEntityDto<Guid>
    {
        public string PowerName { get; set; }  //名称
        public string PowerDetail { get; set; } //详情
    }
}
