using System;
using UserDomainContract.DataContract.Models;
using UserDomainContract.ServerContract.IApplicationServices;
using UserDomainContract.ServerContract.IRepository;

namespace UserApplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserInfoRepository UserRepository;

        public UserService(IUserInfoRepository userRepository)
        {
            UserRepository = userRepository;
        }

        /// <summary>
        /// 根据Id查用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserInfoModel GetUserById(int id)
        {
            var userInfo = UserRepository.GetById(id);
            return UserRepository.ConvertToModel(userInfo);
        }

        /// <summary>
        /// 注册用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns>客户编号</returns>
        public int Register(UserInfoModel userInfo)
        {
            UserRepository.Create(UserRepository.ConvertToEntity(userInfo));
            UserRepository.SaveChanges();
            return userInfo.Id;
        }

        /// <summary>
        /// GC
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
