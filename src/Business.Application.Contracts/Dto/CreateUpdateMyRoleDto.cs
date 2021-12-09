using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
   public  class CreateUpdateMyRoleDto
    {
        [Required]
        public string RoleName { get; set; } //名称
        [Required]
        public string RoleDetail { get; set; }//详情
    }
}
