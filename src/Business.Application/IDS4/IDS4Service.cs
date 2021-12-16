using Business.IIDS4;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.IDS4
{
    public class IDS4Service : IIds4Service
    {

        private readonly IConfiguration GetConfiguration;
        
        public IDS4Service(IConfiguration _configuration)
        {
            this.GetConfiguration = _configuration;
        }

       
        public async Task<string> GetIdsTokenAsync(string LoginName, string LoginPwd)
        {
            var client = new HttpClient();
            var IdsTokenUrl = this.GetConfiguration.GetSection("AuthServer:Authority").Value;//获取访问URl地址
            var AppClientId = this.GetConfiguration.GetSection("AuthServer:AuthorityId").Value;//Ids4访问地址
            var AppClientSecret = this.GetConfiguration.GetSection("AuthServer:AuthorityIdSecret").Value;//Ids4访问密码
            var disco = client.GetDiscoveryDocumentAsync(IdsTokenUrl);

            var ToKenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = disco.Result.TokenEndpoint,
                ClientId = AppClientId,
                ClientSecret = AppClientSecret,
                UserName = LoginName,
                Password = LoginPwd
            });
            if(ToKenResponse.IsError)
            {
                return string.Empty;
            }
            return ToKenResponse.AccessToken;

        }
    }
}
