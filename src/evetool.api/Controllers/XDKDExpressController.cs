using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using evetool.api.Model;
using evetool.core.entity;
using evetool.core.Express;
using evetool.core.Models;
using evetool.db.sqlite;
using Microsoft.AspNetCore.Mvc;

namespace evetool.api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class XDKDExpressController : ControllerBase
    {
        EVEToolDbContext dbcontext;
        public XDKDExpressController(EVEToolDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpPost]
        public decimal CalculatePrice(ExpressGetPriceRequest model)
        {
            var express = new XDKDExpress(model.FeeOption);
            return express.GetCarePrice(model.Price) + express.GetPostFee(model.Volume);
        }
        [HttpGet]
        public ExpressFeeOption GetExpressFeeOption(int id)
        {
            Express exp = new Express(dbcontext);
            return exp.GetExpressOption(id);
        }
        [HttpPost]
        public GetPostFeeFromGameResult GetPostFeeFromGame(ExpressGetPriceRequest model)
        {
            var express = new XDKDExpress(model.FeeOption);
            return express.GetPostFeeFromGame(model.text);
        }
    }
}
