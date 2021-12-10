using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto
{
   public  class CreateUpdateLogisticsDto
    {
        public string LogisticsName { get; set; } //地址
        public DateTime CreateTime { get; set; } //时间
        public string Detail { get; set; }  //详情
    }
}
