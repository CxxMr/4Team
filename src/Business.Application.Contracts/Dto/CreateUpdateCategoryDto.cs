using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Dto
{
    public  class CreateUpdateCategoryDto
    {
        [Required]
        public string CategoryName { get; set; } //种类
    }
}
