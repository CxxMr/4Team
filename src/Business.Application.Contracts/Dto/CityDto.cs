using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class CityDto : AuditedEntityDto<Guid>
    {
        public string CityName { get; set; }//城市名称
        public string CityTid { get; set; }//外键
    }
}
