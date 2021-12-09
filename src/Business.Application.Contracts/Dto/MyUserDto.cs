using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Business.Dto
{
   public  class MyUserDto:AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }   //用户姓名
        public int UserSex { get; set; }  //用户性别
        public string UserAccount { get; set; }  //用户账号
        public string UserPwd { get; set; }//用户密码  需要用到MD5加密
        public string UserHeadPortrait { get; set; }//用户头像
        public int UserAge { get; set; }//用户年龄
    }
}
