using Qiniu.Http;
using Qiniu.Storage;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Helper
{
    public class UploadQiNiuHelper
    {
        public HttpResult UploadVideoTo7new()
        {
            Mac mac = new Mac("AccessKey", "SecretKey");
            // 上传文件名
            string key = "video";
            // 本地文件路径
            string filePath = @"d:\";
            // 存储空间名
            string Bucket = "aaa";

            // 设置上传策略
            PutPolicy putPolicy = new PutPolicy();
            // 设置要上传的目标空间
            putPolicy.Scope = Bucket;
            // 上传策略的过期时间(单位:秒)
            putPolicy.SetExpires(3600);
            // 文件上传完毕后，在多少天后自动被删除
            putPolicy.DeleteAfterDays = 1;
            // 生成上传token
            string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());

            Config config = new Config();
            // 设置上传区域
            config.Zone = Zone.ZONE_CN_North;
            // 设置 http 或者 https 上传
            config.UseHttps = true;
            // 上传是否使用cdn加速
            config.UseCdnDomains = true;
            config.ChunkSize = ChunkUnit.U512K;
            // 表单上传
            FormUploader target = new FormUploader(config);
            HttpResult result = target.UploadFile(filePath, key, token, null);
            //Console.WriteLine("form upload result: " + result.ToString());
            return result;
        }

    }
}
