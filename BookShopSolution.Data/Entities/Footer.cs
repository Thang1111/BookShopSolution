using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class Footer
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public Status Status { get; set; }
    }
}
