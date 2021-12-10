using Business.Dto;
using Business.Helper.Enum;
using Business.IService;
using Business.Model.RBAC;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Business.Service
{
    public class ListUserService : ApplicationService, IListUserService
    {
        private IRepository<MyUserModel, Guid> myUserModels;
        private IRepository<MyRoleModel, Guid> myRoleModels;
        private IRepository<MyPowerModel, Guid> myPowerModels;
        private IRepository<MyUserRoleModel, Guid> myUserRoleModels;
        private IRepository<MyPowerRoleModel, Guid> myPowerRoleModels;

        public ListUserService(IRepository<MyPowerRoleModel, Guid> _myPowerRoleModels,
            IRepository<MyUserModel, Guid> _myUserModels,
             IRepository<MyPowerModel, Guid> _myPowerModels,
               IRepository<MyUserRoleModel, Guid> _myUserRoleModels,
               IRepository<MyRoleModel, Guid> _myRoleModels)
        {
            myPowerRoleModels = _myPowerRoleModels;
            myUserModels = _myUserModels;
            myPowerModels = _myPowerModels;
            myUserRoleModels = _myUserRoleModels;
            myRoleModels = _myRoleModels;
        }

        public async Task<ResulstHelper<PagedResultDto<ListUserDto>>> PagedResultDto(int PageIndex,int PageSize)
        {
            var linq = await (from UR in myUserRoleModels
                              join
                              U in myUserModels on UR.UserId equals U.Id.ToString()
                              join R in myRoleModels on UR.RoleId equals R.Id.ToString()
                              join PR in myPowerRoleModels on R.Id.ToString() equals PR.Id.ToString()
                              join P in myPowerModels on PR.Id equals P.Id
                              select new ListUserDto
                              {
                                  UserAccount = U.UserAccount
                              }).ToListAsync();
              var total= linq.Count();
            var data = linq.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            var Date = new PagedResultDto<ListUserDto>(total, data);
            return new ResulstHelper<PagedResultDto<ListUserDto>>
            {
                 Data=Date
            };

        }

        //public Task<PagedResultDto<List<ListUserDto>>> PagedResultDto()
        //{
        //    var linq = (from UR in myUserRoleModels
        //                join
        //                U in myUserModels on UR.UserId equals U.Id.ToString()
        //                join R in myRoleModels on UR.RoleId equals R.Id.ToString()
        //                join PR in myPowerRoleModels on R.Id.ToString() equals PR.Id.ToString()
        //                join P in myPowerModels on PR.Id equals P.Id
        //                select new ListUserDto
        //                {
        //                    UserAccount = U.UserAccount
        //                }).ToList();
        //    return linq;
        //}






        //联查
        //public   async    Task<>List<ListUserDto> GetListUser()
        //{


        //    var  linq = (from UR in myUserRoleModels join
        //                U in myUserModels on UR.UserId equals U.Id.ToString() 
        //                join R in myRoleModels on UR.RoleId equals R.Id.ToString()  
        //                join PR in myPowerRoleModels on R.Id.ToString() equals PR.Id.ToString() 
        //                join P in myPowerModels on PR.Id equals P.Id
        //                     select new ListUserDto()
        //                     {
        //                           UserAccount = U.UserAccount
        //                     }).ToList();
        //    return linq;
        //}





    }
}
