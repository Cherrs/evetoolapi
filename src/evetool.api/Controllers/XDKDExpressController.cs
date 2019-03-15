using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using evetool.api.Model;
using evetool.core.Express;
using Microsoft.AspNetCore.Mvc;

namespace evetool.api.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class XDKDExpressController : ControllerBase
    {
        [HttpGet]
        public decimal GetPrice(ExpressGetPriceRequest model)
        {
            var express = new XDKDExpress(model.FeeOption);
            return express.GetCarePrice(model.Price) + express.GetPostFee(model.Volume);
        }
    }
}
