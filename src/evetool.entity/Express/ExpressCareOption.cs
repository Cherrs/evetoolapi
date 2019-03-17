using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.core.entity
{
    public class ExpressCareOption
    {
        public int ID { get; set; }
        /// <summary>
        /// 开始计算保险费用
        /// </summary>
        public decimal MinPrice { get; set; }
        /// <summary>
        /// 保险比例
        /// </summary>
        public double Ratio { get; set; }

        public List<ExpressFeeOption> ExpressFeeOption { get; set; }
    }
}
