using System;
using System.Collections.Generic;
using System.Text;
using evetool.core.model;
using Microsoft.EntityFrameworkCore;

namespace evetool.core.Express
{
    /// <summary>
    /// 快递计算
    /// </summary>
    public class XDKDExpress
    {
        ExpressFeeOption _Option;
        public XDKDExpress(ExpressFeeOption Option)
        {
            _Option = Option;
        }
        /// <summary>
        /// 获取运费
        /// </summary>
        /// <param name="Volume">体积</param>
        /// <returns></returns>
        public decimal GetPostFee(double Volume)
        {
            var jifeim2 = Math.Ceiling((Volume - _Option.FloatingVolume) / _Option.IncrementVolume);
            if (jifeim2 == 0)
                jifeim2 = 1;

            return (decimal)jifeim2 * (_Option.UnitPrice * (decimal)_Option.IncrementVolume);
        }
        /// <summary>
        /// 获取保险价格
        /// </summary>
        /// <param name="Price"></param>
        /// <returns></returns>
        public decimal GetCarePrice(decimal Price)
        {
            if (_Option.IsCare)
            {
                if (Price > _Option.Care.MinPrice)
                {
                    return Price * (decimal)_Option.Care.Ratio;
                }
            }
            return 0;
        }

    }
}
