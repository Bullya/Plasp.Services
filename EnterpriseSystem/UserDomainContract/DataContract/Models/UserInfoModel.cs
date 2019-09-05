using BaseDomainContract.DataContract.Enum;
using System;

namespace UserDomainContract.DataContract.Models
{
    public class UserInfoModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public UserSex Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string NativePlace { get; set; }

        /// <summary>
        /// 住址
        /// </summary
        public string Address { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否注销
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
