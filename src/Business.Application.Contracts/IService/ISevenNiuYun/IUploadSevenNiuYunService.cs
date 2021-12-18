using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.IService.ISevenNiuYun
{
    public  interface IUploadSevenNiuYunService:IApplicationService
    {
       public  bool ImgHelper(IFormFile file);

        public bool UpLoading(string upLoadFile);
    }


   
}

