using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
   public  class CreateUpdateFileImgDto
    {
        [Required]
        public string ImgUrl { get; set; }  //图片路径
    }
}
