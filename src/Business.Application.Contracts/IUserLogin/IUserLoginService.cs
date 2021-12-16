using Business.Dto;
using Business.Helper.Enum;
using Business.IIDS4;
using Business.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Business.IUserLogin
{
    public interface IUserLoginService: IApplicationService
    {
        //注册
        ResulstHelper<int> Registered(CreateUpdateMyUserDto dto);

       public  Task<MyUserDto>  PostUserLogin(MyUserDto dto);

        public Task<LiveShopResData<string>> GetIds4Async(string LoginName, string LoginPwd);
    }
}
