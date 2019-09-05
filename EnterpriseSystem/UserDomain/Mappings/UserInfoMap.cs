using BaseDomainContract.DataContract.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserDomainContract.DataContract.Entitys;

namespace UserDomain.Mappings
{
    public class UserInfoMap : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            //官方有提供 "内置转换器"
            //builder
            //    .Entity<UserInfo>()
            //    .Property(e => e.Mount) 
            //    .HasConversion(
            //        v => v.ToString(),
            //        v => (EquineBeast)Enum.Parse(typeof(UserSex), v));
            //var userSexConverter = new EnumToStringConverter<UserSex>();
            //builder.Property(c => c.Sex)
            //    .HasConversion(userSexConverter);

            builder.Property(c => c.Sex)
                .HasDefaultValue(UserSex.Default);

            builder.Property(c => c.IsDelete)
                .HasDefaultValue(false);
        }
    }
}
