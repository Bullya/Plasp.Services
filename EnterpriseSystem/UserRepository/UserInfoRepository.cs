using BaseDomain;
using System.Collections.Generic;
using System.Linq;
using UserDomain.Contexts;
using UserDomainContract.DataContract.Entitys;
using UserDomainContract.DataContract.Models;
using UserDomainContract.ServerContract.IRepository;

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

        #region Convert

        public UserInfoModel ConvertToModel(UserInfo entity)
        {
            if (entity == null)
                return null;

            return new UserInfoModel
            {
                Id = entity.Id,
                UserName = entity.UserName,
                Password = entity.Password,
                Sex = entity.Sex,
                Age = entity.Age,
                NativePlace = entity.NativePlace,
                Address = entity.Address,
                Phone = entity.Phone,
                CreateTime = entity.CreateTime,
                IsDelete = entity.IsDelete
            };
        }

        public UserInfo ConvertToEntity(UserInfoModel model)
        {
            if (model == null)
                return null;

            return new UserInfo
            {
                Id = model.Id,
                UserName = model.UserName,
                Password = model.Password,
                Sex = model.Sex,
                Age = model.Age,
                NativePlace = model.NativePlace,
                Address = model.Address,
                Phone = model.Phone,
                CreateTime = model.CreateTime,
                IsDelete = model.IsDelete
            };
        }

        public IEnumerable<UserInfoModel> ConvertToModels(IEnumerable<UserInfo> entities)
        {
            return entities.Select(ConvertToModel);
        }

        public IEnumerable<UserInfo> ConvertToEntitys(IEnumerable<UserInfoModel> models)
        {
            return models.Select(ConvertToEntity);
        }

        #endregion
    }
}
