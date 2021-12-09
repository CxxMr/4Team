using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
    public class MyUserRoleDto : AuditedEntityDto<Guid>
    {
        public string UserId { get; set; }//用户外键
        public string RoleId { get; set; }//角色外键

    }
}
