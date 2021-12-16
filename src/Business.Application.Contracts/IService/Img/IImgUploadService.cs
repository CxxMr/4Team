using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Business.IService.Img
{
   public  interface  IImgUploadService: IApplicationService
    {
        string ImgHelper(IFormFile file);
    }
}
