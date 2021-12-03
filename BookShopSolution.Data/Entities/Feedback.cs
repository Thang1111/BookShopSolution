using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Status Status { get; set; }

       /* public virtual User Customer { get; set; }*/
    }
}
