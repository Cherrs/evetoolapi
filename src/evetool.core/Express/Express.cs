using System;
using System.Collections.Generic;
using System.Text;
using evetool.core.entity;
using evetool.db.sqlite;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace evetool.core.Express
{
    public class Express : CoreBase
    {
        public Express(EVEToolDbContext db) : base(db)
        {
        }

        public ExpressFeeOption GetExpressOption(int id)
        {
            return this.DbContext.ExpressFeeOptions.Where(x => x.ID == id).Include(x=>x.Care).SingleOrDefault();
        }
    }
}
