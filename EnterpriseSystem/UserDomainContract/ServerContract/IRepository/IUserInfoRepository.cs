using BaseDomainContract.ServerContract;
using BaseDomainContract.ServerContract.IService;
using UserDomainContract.DataContract.Entitys;
using UserDomainContract.DataContract.Models;

namespace UserDomainContract.ServerContract.IRepository
{
    public interface IUserInfoRepository : IRepository<UserInfo>, IModelConvert<UserInfoModel, UserInfo>
    {
        UserInfo GetById(int id);
    }
}
