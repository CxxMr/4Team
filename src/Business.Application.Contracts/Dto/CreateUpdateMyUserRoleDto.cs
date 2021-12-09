using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
   public  class CreateUpdateMyUserRoleDto
    {
        [Required]
        public string UserId { get; set; }//用户外键
        [Required]
        public string RoleId { get; set; }//角色外键
    }
}
