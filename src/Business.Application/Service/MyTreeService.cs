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
   public  class MyTreeService : CrudAppService<MyTreeModel, MyTreeDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateMyTreeDto>, IMyTreeService
    {
        private readonly IRepository<MyTreeModel, Guid> myRoleModels;

        public MyTreeService(IRepository<MyTreeModel, Guid> _myRoleModels)
           : base(_myRoleModels)
        {
            myRoleModels = _myRoleModels;
        }

        //权限树 调用递归

        public async Task<List<MyTreeDto>> GetTreeAsync(string guid="0")
        {
            return await GetTreeMunsAsync(guid);
        }
        
        //递归
        private async Task<List<MyTreeDto>> GetTreeMunsAsync(string guid)
        {
            var Tree = await myRoleModels.GetListAsync();
            Tree = Tree.Where(x => x.TreeTid.Equals(guid)).ToList();
            List<MyTreeDto> myTreeDtos = new List<MyTreeDto>();
            Tree.ForEach(async x =>
           {
               MyTreeDto treeDto = new MyTreeDto();
               treeDto.Label = x.TreeName;
               treeDto.Url = x.TreeUrl;
               treeDto.Children = await GetTreeMunsAsync(x.Id.ToString());
               myTreeDtos.Add(treeDto);
           });
            return myTreeDtos;
        }
    }

    //public class TreeMuns
    //{
    //    public string Label { get; set; }
    //    public string  Url { get; set; }
    //    public List<TreeMuns> Children { get; set; }

    //}


}
