using Business.Model.Goods;
using Business.Dto;
using Business.IService;
using Business.Model.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Service
{
    public class OrderFormService : CrudAppService<OrderForm, OrderFormDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderFormDto>, IOrderFormService
    {
        public OrderFormService(IRepository<OrderForm, Guid> myRoleModels) : base(myRoleModels) { }
    }
}
