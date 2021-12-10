using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto
{

    //验证
    class CreateUpDateListUserDto
    {
        public string PowerName { get; set; }  //名称
        public string PowerDetail { get; set; } //详情
        public string PowerId { get; set; } //权限表
        public string RoleId { get; set; }//角色表
        public string RoleName { get; set; } //名称
        public string RoleDetail { get; set; }//详情
        public string UserName { get; set; }   //用户姓名
        public int UserSex { get; set; }  //用户性别
        public string UserAccount { get; set; }  //用户账号
        public string UserPwd { get; set; }//用户密码  需要用到MD5加密
        public string UserHeadPortrait { get; set; }//用户头像
        public int UserAge { get; set; }//用户年龄
        public string UserId { get; set; }//用户外键
    }
}
