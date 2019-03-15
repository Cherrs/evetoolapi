using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace evetool.core.Express
{
    public class GetExpressOption : CoreBase
    {
        public GetExpressOption(DbContext db) : base(db)
        {
        }
    }
}
