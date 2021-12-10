using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class MyTreeDto : AuditedEntityDto<Guid>
    {
        public string Label { get; set; }
        public string Url { get; set; }
        public List<MyTreeDto> Children { get; set; }
    }
}
