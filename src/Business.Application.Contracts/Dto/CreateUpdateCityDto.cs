using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
    public class CreateUpdateCityDto
    {
        [Required]
        public string CityName { get; set; }//城市名称
        [Required]
        public string CityTid { get; set; }//外键
    }
}
