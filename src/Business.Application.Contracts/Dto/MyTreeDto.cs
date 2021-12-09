using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class MyTreeDto : AuditedEntityDto<Guid>
    {
        public string TreeName { get; set; }  //名称
        public string TreeTid { get; set; } //递归外键
        public string TreeUrl { get; set; } //地址
    }
}
