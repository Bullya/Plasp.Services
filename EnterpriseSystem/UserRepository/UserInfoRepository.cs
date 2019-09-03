using BaseDomain;
using System.Linq;
using UserDomain.Contexts;
using UserDomainContract.DataContract;
using UserDomainContract.ServerContract;

namespace UserRepository
{
    public class UserInfoRepository : BaseRepository<UserDbContext, UserInfo>, IUserInfoRepository
    {
        public UserInfoRepository(UserDbContext userDbContext)
            : base(userDbContext) { }

        public UserInfo GetById(int id)
        {
            if (id == 0)
                return null;

            var query = GetQueryable(i => i.Id == id);
            return query.FirstOrDefault();
        }
    }
}
