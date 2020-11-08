using System;
using System.Collections.Generic;

namespace XYZSports.Models
{
    public partial class SalesGroup : TrackedEntity
    {
        public SalesGroup()
        {
            Salespeople = new HashSet<Salesperson>();
        }
        public string State { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Salesperson> Salespeople { get; set; }

    }
}
