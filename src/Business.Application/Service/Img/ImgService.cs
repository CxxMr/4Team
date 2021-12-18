using Business.Helper;
using Business.IService.Img;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.Service.Img
{
    public class ImgService : ApplicationService, IImgUploadService
    {
        public string ImgHelper(IFormFile file)
        {
            var url= UploadHelper.Upload(file);

            return url;
      }
    }
}
