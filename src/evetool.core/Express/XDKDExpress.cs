using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using evetool.core.entity;
using evetool.core.Models;
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

        public GetPostFeeFromGameResult GetPostFeeFromGame(string text)
        {
            HttpClient client = new HttpClient();
            var textarr = text.Split(new string[] { Environment.NewLine,"\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder quarytxt = new StringBuilder();
            foreach (var i in textarr)
            {
                int count;
                var row = i.Split(new string[] { "\t" }, StringSplitOptions.None);
                try
                {

                    count = int.Parse(row[2], System.Globalization.NumberStyles.AllowThousands);
                }
                catch
                {
                    if (string.IsNullOrEmpty(row[1]))
                        count = 1;
                    else
                        count = int.Parse(row[1], System.Globalization.NumberStyles.AllowThousands);
                }

                var type = EVEData.ShipNames.Where(x => x.Value.name.zh == row[0].Trim() || x.Value.name.en == row[0].Trim());
                quarytxt.Append(type.FirstOrDefault().Value.name.en);
                quarytxt.Append(" ");
                quarytxt.Append(count);
                quarytxt.Append("\r\n");
            }

            var priceresult = client.PostAsync("https://evepraisal.com/appraisal.json?market=jita", new StringContent(quarytxt.ToString())).Result;
            var price = priceresult.Content.ReadAsAsync<evepraisalResult>().Result;
            var result = new GetPostFeeFromGameResult
            {
                BuyPrice = price.appraisal.totals.buy,
                SellPrice = price.appraisal.totals.sell,
                Volume = price.appraisal.totals.volume,
            };
            result.PostFee = GetPostFee(result.Volume);
            result.CarePrice = GetCarePrice(result.SellPrice);
            return result;
        }

    }
}
