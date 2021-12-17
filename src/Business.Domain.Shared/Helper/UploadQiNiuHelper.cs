using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Business.Helper
{
    public class UploadQiNiuHelper
    {
        //private readonly QnySetting _Qny;
        //public UploadQiNiuHelper(IOptions<QnySetting> Qny)
        //{
        //    _Qny = Qny.Value;
        //}

        //public List<Object> UploadVideoTo7new()
        //{
        //    Mac mac = new Mac(_Qny.qiniuyunAK, _Qny.qiniuyunSK);// AK SK使用
        //    PutPolicy putPolicy = new PutPolicy();
        //    putPolicy.Scope = _Qny.qiniuyunBucket;
        //    string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());//token生成
        //    IFormFileCollection files = Request.Form.Files;
        //    Config config = new Config()
        //    {
        //        Zone = Zone.ZONE_CN_East,
        //        UseHttps = true
        //    };
        //    var res = Request.Form.ToArray();

        //    FormUploader upload = new FormUploader(config);
        //    HttpResult result = new HttpResult();
        //    List<Object> list = new List<Object>();
        //    foreach (IFormFile file in files)//获取多个文件列表集合
        //    {
        //        if (file.Length > 0)
        //        {
        //            var _fileName = ContentDispositionHeaderValue
        //                            .Parse(file.ContentDisposition)
        //                            .FileName
        //                            .Trim('"');
        //            var _qiniuName = _Qny.prefixPath + "/" + DateTime.Now.ToString("yyyyMMddHHmmssffffff") + _fileName;//重命名文件加上时间戳
        //            Stream stream = file.OpenReadStream();
        //            result = upload.UploadStream(stream, _qiniuName, token, null);
        //            if (result.Code == 200)
        //            {
        //                list.Add(new { fileName = _fileName, qiniuName = _qiniuName, uploadTime = DateTime.Now });
        //            }
        //            else
        //            {
        //                throw new Exception(result.RefText);//上传失败错误信息
        //            }
        //        }
        //    }
        //    return list;
        //}

    }
    public class QnySetting
    {
        public string qiniuyunAK { get; set; }
        public string qiniuyunSK { get; set; }
        public string qiniuyunBucket { get; set; }
        public string prefixPath { get; set; }
    }
}
