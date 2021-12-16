using Business.IService.ISevenNiuYun;
using Newtonsoft.Json;
using Qiniu.Http;
using Qiniu.IO;
using Qiniu.IO.Model;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.Service.SevenNiuYun
{
    public class UploadSevenNiuYunService : ApplicationService, IUploadSevenNiuYunService
    {
        /// 实现将文件上传到七牛云
        /// </summary>
        /// <param name="stream">文件流</param>
        /// <param name="fileName">文件名称</param>
        /// <returns></returns>

        public UploadQiNiuResult UploadQiNiuResult(byte[] stream, string fileName)
        {
                Mac mac = new Mac(BlogStatic.QiNiuInfo_AccessKey, BlogStatic.QiNiuInfo_SecretKey);
                // 上传策略，参见
                // https://developer.qiniu.com/kodo/manual/put-policy
                PutPolicy putPolicy = new PutPolicy();
                // 如果需要设置为"覆盖"上传(如果云端已有同名文件则覆盖)，请使用 SCOPE = "BUCKET:KEY"
                // putPolicy.Scope = bucket + ":" + saveKey;
                var saveKey = string.Format("BlogImg/{0}/", DateTime.Now.ToString("yyyy/MM/dd")) + fileName;
                putPolicy.Scope = "blog:" + saveKey;
                // 上传策略有效期(对应于生成的凭证的有效期)
                putPolicy.SetExpires(3600);
                // 上传到云端多少天后自动删除该文件，如果不设置（即保持默认默认）则不删除
                // putPolicy.DeleteAfterDays = 1;
                string jstr = putPolicy.ToJsonString();
                //获取上传凭证
                var uploadToken = Auth.CreateUploadToken(mac, jstr);
                UploadManager um = new UploadManager();

                HttpResult result = um.UploadData(stream, saveKey, uploadToken);

                if (result.Code == 200)
                {
                    return JsonConvert.DeserializeObject<UploadQiNiuResult>(result.Text);
                }
                return null;
            }
        }
    public static  class BlogStatic
    {
        public static string QiNiuInfo_AccessKey { get; set; }
        public static string QiNiuInfo_SecretKey { get; set; }

    }
}
