using BaseDomainContract.DataContract.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDomainContract.DataContract.Entitys
{
    [Table("user_info")]
    public class UserInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key, Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Column("user_name", TypeName = "varchar(20)"), Required]
        public string UserName { get; set;}

        /// <summary>
        /// 密码
        /// </summary>
        [Column("password", TypeName = "varchar(20)"), Required]
        public string Password { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Column("sex")]
        public UserSex Sex { get; set; } 

        /// <summary>
        /// 年龄
        /// </summary>
        [Column("age")]
        public int Age { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [Column("native_place", TypeName = "varchar(60)")]
        public string NativePlace { get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [Column("address", TypeName = "varchar(60)")]
        public string Address { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Column("phone", TypeName = "varchar(20)")]
        public string Phone { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("create_time", TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否注销
        /// </summary>
        [Column("isdelete")]
        public bool IsDelete { get; set; }
    }
}
