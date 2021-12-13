using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.IIDS4
{
   public  interface IIds4Service
    {

        public Task<string> GetIdsTokenAsync(string LoginName, string LoginPwd);

    }
}
