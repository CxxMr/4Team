using AutoMapper;
using Business.Dto;
using Business.Model.RBAC;

namespace Business
{
    public class BusinessApplicationAutoMapperProfile : Profile
    {
        public BusinessApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            //用户添加映射  有Dto验证
            CreateMap<MyUserModel, MyUserDto>(); 
            CreateMap<CreateUpdateMyUserDto,MyUserModel > ();
            //角色添加映射 
            CreateMap<MyRoleModel, MyRoleDto>();
            CreateMap<CreateUpdateMyRoleDto, MyRoleModel>();
            //权限
            CreateMap<MyPowerModel, MyPowerDto>();
            CreateMap<CreateUpdateMyPowerDto, MyPowerModel>();
            //角色权限
            CreateMap<MyPowerRoleModel, MyPowerRoleDto>();
            CreateMap<CreateUpdateMyPowerRoleDto, MyPowerRoleModel>();
            //用户角色
            CreateMap<MyUserRoleModel, MyUserRoleDto>();
            CreateMap<CreateUpdateMyUserRoleDto, MyUserRoleModel>();



        }
    }
}
