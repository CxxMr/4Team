using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
    public   class FileImgDto : AuditedEntityDto<Guid>
    {
        public string ImgUrl { get; set; }  //图片路径
    }
}
