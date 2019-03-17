using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.core.entity
{
    /// <summary>
    /// 运费配置
    /// </summary>
    public class ExpressFeeOption
    {
        public int ID { get; set; }
        /// <summary>
        /// 运费单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 体积递增
        /// </summary>
        public double IncrementVolume { get; set; }
        /// <summary>
        /// 体积上下浮动
        /// </summary>
        public double FloatingVolume { get; set; }
        /// <summary>
        /// 免费体积
        /// </summary>
        public double FreeVolume { get; set; }
        /// <summary>
        /// 是否使用保险
        /// </summary>
        public bool IsCare { get; set; }
        /// <summary>
        /// 保险配置
        /// </summary>
        public ExpressCareOption Care { get; set; }
    }
}
