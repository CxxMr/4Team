using System;
using System.Collections.Generic;
using System.Text;

namespace Business.IService
{
    public class LiveShopResData<T>
    {
        public ShopStatus Status { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T Info { get; set; }

        /// <summary>
        /// 返回失败信息
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        /// <param name="resStatus"></param>
        /// <returns></returns>
        public LiveShopResData<T> Error(T t, Exception ex, ShopStatus shopStatus = ShopStatus.Failure)
        {
            return new LiveShopResData<T>() { Info = t, Msg = ex.Message, Status = shopStatus };
        }
    }
}
