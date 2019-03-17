using evetool.db.sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.core
{
    public abstract class CoreBase
    {
        public EVEToolDbContext DbContext { get; set; }
        public CoreBase(EVEToolDbContext db)
        {
            DbContext = db;
        }
    }
}
