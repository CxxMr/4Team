using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class MyPowerRoleDto : AuditedEntityDto<Guid>
    {
        public string PowerId { get; set; } //权限表
        public string RoleId { get; set; }//角色表
    }
}
