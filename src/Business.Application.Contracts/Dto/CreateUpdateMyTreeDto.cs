using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
   public  class CreateUpdateMyTreeDto
    {
        [Required]
        public string TreeName { get; set; }  //名称
        [Required]
        public string TreeTid { get; set; } //递归外键
        [Required]
        public string TreeUrl { get; set; } //地址
    }
}
