using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
    public class CreateUpdateMyUserDto
    {
        [Required]
        public string UserName { get; set; }   //用户姓名
        [Required]
        public int UserSex { get; set; }  //用户性别
        [Required]
        public string UserAccount { get; set; }  //用户账号
        [Required]
        public string UserPwd { get; set; }//用户密码  需要用到MD5加密
        [Required]
        public string UserHeadPortrait { get; set; }//用户头像
        [Required]
        public int UserAge { get; set; }//用户年龄
    }
}
