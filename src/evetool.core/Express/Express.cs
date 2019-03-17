using System;
using System.Collections.Generic;
using System.Text;
using evetool.core.model;
using Microsoft.EntityFrameworkCore;

namespace evetool.core.Express
{
    public class Express : CoreBase
    {
        public Express(EVEToolDbContext db) : base(db)
        {
        }

        public ExpressFeeOption GetExpressOption(int id)
        {
            this.DbContext.
        }
    }
}
