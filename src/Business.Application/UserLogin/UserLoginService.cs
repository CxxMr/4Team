using Business.Dto;
using Business.Helper.Enum;
using Business.Helper.Reptiles;
using Business.IUserLogin;
using Business.Model.RBAC;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Business.Helper;
using Microsoft.Extensions.Configuration;
using Business.IIDS4;
using Business.IDS4;
using Business.IService;

namespace Business.UserLogin
{

    public class UserLoginService : ApplicationService, IUserLoginService
    {
        private readonly IRepository<MyUserModel, Guid> myRoleModels;
        private IConfiguration GetConfiguration;

        public UserLoginService(IRepository<MyUserModel, Guid> _myRoleModels , IConfiguration _configuration) : base()
        {
            myRoleModels = _myRoleModels;
            GetConfiguration = _configuration;
        }
     
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public ResulstHelper<int> Registered(CreateUpdateMyUserDto dto)
        {
            dto.UserPwd = MD5.MD5Encrypt.MD5Encrypt16(dto.UserPwd);

            var data = myRoleModels.InsertAsync(ObjectMapper.Map<CreateUpdateMyUserDto, MyUserModel>(dto));

            if (data != null)
            {
                return new ResulstHelper<int>
                {
                    Message = "注册成功！",
                };
            }
            else
            {
                return new ResulstHelper<int>
                {
                    Message = "注册失败！",
                };
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
       public  async Task<MyUserDto>  PostUserLogin(MyUserDto dto)
        {
            dto.UserPwd = MD5.MD5Encrypt.MD5Encrypt16(dto.UserPwd);

            var ls = await myRoleModels.GetListAsync();

            var str = ls.Where(x => x.UserAccount.Equals(dto.UserAccount) && x.UserPwd.Equals(dto.UserPwd)).FirstOrDefault();

            var date = await Task.FromResult(ObjectMapper.Map<MyUserModel, MyUserDto>(str));

            return date;
        }


       public  async Task<LiveShopResData<string>>  GetIds4Async(string LoginName, string LoginPwd)
        {
            IDS4Service ids4Service = new IDS4Service(GetConfiguration);
            string token = await ids4Service.GetIdsTokenAsync(LoginName,LoginPwd);
            return new LiveShopResData<string>() { Status = ShopStatus.Succeed, Msg = "获取token成功", Info = token };
        }
    }
}

       
       
    

