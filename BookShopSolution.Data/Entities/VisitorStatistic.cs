using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class VisitorStatistic
    {
        public Guid Id { get; set; }
        public DateTime VisitedDate { get; set; }
        public string Ipaddress { get; set; }
    }
}
