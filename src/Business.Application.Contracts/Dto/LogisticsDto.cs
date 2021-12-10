using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class LogisticsDto : AuditedEntityDto<Guid>
    {
        public string LogisticsName { get; set; } //地址
        public DateTime CreateTime { get; set; } //时间
        public string Detail { get; set; }  //详情
    }
}
