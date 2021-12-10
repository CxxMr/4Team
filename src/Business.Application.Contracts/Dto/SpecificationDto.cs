using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
    public class SpecificationDto : AuditedEntityDto<Guid>
    {
        public string SpecificationName { get; set; } //规格值
    }
}
