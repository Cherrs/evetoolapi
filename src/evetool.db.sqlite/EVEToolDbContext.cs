using evetool.core.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.db.sqlite
{
    public class EVEToolDbContext: DbContext
    {
        public EVEToolDbContext(DbContextOptions<EVEToolDbContext> options)
    : base(options)
        { }

        /// <summary>
        /// 保险设置
        /// </summary>
        public DbSet<ExpressCareOption> ExpressCareOptions { get; set; }
        /// <summary>
        /// 运费设置
        /// </summary>
        public DbSet<ExpressFeeOption> ExpressFeeOptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.db");
        }
    }
}
