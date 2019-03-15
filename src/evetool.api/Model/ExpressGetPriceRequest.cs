using evetool.core.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace evetool.api.Model
{
    public class ExpressGetPriceRequest
    {
        public string text { get; set; }
        /// <summary>
        /// 体积
        /// </summary>
        public double Volume { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        public ExpressFeeOption FeeOption { get; set; }
    }
}
