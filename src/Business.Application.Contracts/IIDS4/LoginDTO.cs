using System;
using System.Collections.Generic;
using System.Text;

namespace Business.IIDS4
{
   public  class LoginDTO
    {
        /// <summary>
        ///  是否成功
        /// </summary>

        public  bool State  { get; set; } 

        /// <summary>
        ///  token
        /// </summary>

        public  string Token  { get; set; }
    }
}
