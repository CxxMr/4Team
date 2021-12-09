using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
   public  class CreateUpdateMyPowerDto
    {
        [Required]
        public string PowerName { get; set; }  //名称
        [Required]
        public string PowerDetail { get; set; } //详情
    }
}
