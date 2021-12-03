using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class Order
    {
        /*public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }*/

        public int Id { get; set; }
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public OrderStatus Status { get; set; }

       /* public virtual User Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }*/
    }
}
