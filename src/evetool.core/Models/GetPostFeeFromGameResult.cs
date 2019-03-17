using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.core.Models
{
    /// <summary>
    /// 合同计算返回值
    /// </summary>
    public class GetPostFeeFromGameResult
    {        /// <summary>
             /// 吉他卖价
             /// </summary>
        public decimal BuyPrice { get; set; }

        /// <summary>
        /// 吉他收价
        /// </summary>
        public decimal SellPrice { get; set; }
        /// <summary>
        /// 总体积
        /// </summary>
        public double Volume { get; set; }
        /// <summary>
        /// 预估快递费
        /// </summary>
        public decimal PostFee { get; set; }
        /// <summary>
        /// 预估保险价格
        /// </summary>
        public decimal CarePrice { get; set; }
    }
}
