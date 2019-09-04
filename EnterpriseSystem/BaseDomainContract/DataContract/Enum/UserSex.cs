using System.ComponentModel;

namespace BaseDomainContract.DataContract.Enum
{
    public enum UserSex
    {
        [Description("保密")] Default = 0,
        [Description("男")] Man = 1,
        [Description("女")] WoMan = 2
    }
}
