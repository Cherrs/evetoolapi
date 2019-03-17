using System;
using System.Collections.Generic;
using System.Text;

namespace evetool.core.Models
{
    public class appraisal
    {
        public totals totals { get; set; }
    }

    public class totals
    {
        public decimal buy { get; set; }

        public decimal sell { get; set; }

        public double volume { get; set; }
    }
}
