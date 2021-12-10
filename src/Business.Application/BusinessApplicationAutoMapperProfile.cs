using AutoMapper;
using Business.Dto;
using Business.Model.Goods;
using Business.Model.RBAC;
using Business.Model.Virtual;

namespace Business
{
    public class BusinessApplicationAutoMapperProfile : Profile
    {
        public BusinessApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            //RBAC映射
            #region
            //用户添加映射  有Dto验证
            CreateMap<MyUserModel, MyUserDto>();
            CreateMap<CreateUpdateMyUserDto, MyUserModel>();
            //角色添加映射 
            CreateMap<MyRoleModel, MyRoleDto>();
            CreateMap<CreateUpdateMyRoleDto, MyRoleModel>();
            //权限
            CreateMap<MyPowerModel, MyPowerDto>();
            CreateMap<CreateUpdateMyPowerDto, MyPowerModel>();
            //角色权限
            CreateMap<MyPowerRoleModel, MyPowerRoleDto>();
            CreateMap<CreateUpdateMyPowerRoleDto, MyPowerRoleModel>();

            #endregion 

            //商品映射
            #region
            //商品分类
            CreateMap<CategoryModel, CategoryDto>();
            CreateMap<CreateUpdateCategoryDto, CategoryModel>();
            //城市
            CreateMap<CityModel, CityDto>();
            CreateMap<CreateUpdateCityDto, CityModel>();
            //商品图片
            CreateMap<FileImg, FileImgDto>();
            CreateMap<CreateUpdateFileImgDto, FileImg>();
            //商品订单
            CreateMap<GoodsModel, GoodsDto>();
            CreateMap<CreateUpdateGoodsDto, GoodsModel>();
            //购物车
            CreateMap<ShoppingModel, ShoppingDto>();
            CreateMap<CreateUpdateShoppingDto, ShoppingModel>();
            //物流信息
            CreateMap<LogisticsModel, LogisticsDto>();
            CreateMap<CreateUpdateLogisticsDto, LogisticsModel>();
            //商品规格
            CreateMap<SpecificationModel, SpecificationDto>();
            CreateMap<CreateUpdateSpecificationDto, SpecificationModel>();

            #endregion

        }

    }
}
