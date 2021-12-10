using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Helper.Enum
{
    public class ResulstHelper<T>
    { 
        /// <summary>
        /// 状态码
        /// </summary>
       public Helper.Enum.EnumHelper ResultState { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 数据信息
        /// </summary>
        public T Data { get; set; }



    }

    
}
