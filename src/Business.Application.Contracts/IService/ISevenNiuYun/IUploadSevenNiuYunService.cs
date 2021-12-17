using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.IService.ISevenNiuYun
{
    public  interface IUploadSevenNiuYunService:IApplicationService
    {
        public bool UpLoading(string upLoadFile);
    }


   
}

