using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.IService.ISevenNiuYun
{
    public  interface IUploadSevenNiuYunService:IApplicationService
    {
        public abstract UploadQiNiuResult UploadQiNiuResult(byte[] stream, string fileName);
    }


    public class UploadQiNiuResult
     {  
       public string Hash { get; set; }
       public string Key { get; set; }
    }
}

