using System;
using UserDomainContract.DataContract.Models;

namespace UserDomainContract.ServerContract.IApplicationServices
{
    public interface IUserService : IDisposable
    {
        int Register(UserInfoModel userInfo);
        UserInfoModel GetUserById(int id);
    }
}
