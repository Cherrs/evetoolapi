using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.core
{
    public abstract class CoreBase
    {
        public DbContext DbContext { get; set; }
        public CoreBase(DbContext db)
        {
            DbContext = db;
        }
    }
}
