using BaseDomainContract.ServerContract;
using UserDomainContract.DataContract;

namespace UserDomainContract.ServerContract
{
    public interface IUserInfoRepository : IRepository<UserInfo>
    {
        UserInfo GetById(int id);
    }
}
