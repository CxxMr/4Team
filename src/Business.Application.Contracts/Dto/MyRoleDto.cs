using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
    public class MyRoleDto : AuditedEntityDto<Guid>
    {
        public string RoleName { get; set; } //名称
        public string RoleDetail { get; set; }//详情
    }
}
