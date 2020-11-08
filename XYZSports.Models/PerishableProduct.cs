using System;
using System.Collections.Generic;

namespace XYZSports.Models
{
    public partial class PerishableProduct : Product
    {     
        public int? ExpirationDays { get; set; }
        public bool? Refrigerated { get; set; }

    }
}
