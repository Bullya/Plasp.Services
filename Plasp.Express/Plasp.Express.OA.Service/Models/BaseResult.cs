using System.ComponentModel;

namespace Plasp.Express.OA.Service.Models
{
    public class BaseResult
    {
        /// <summary>
        /// 执行结果
        /// </summary>
        public RunStatus Status { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
    }

    public enum RunStatus
    {
        [Description("失败")] Failed = 0,

        [Description("成功")] Success = 1,        
    }
}
