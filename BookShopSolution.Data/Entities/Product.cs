using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class Product
    {
        /*public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }*/

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Alias { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public int? PublisherId { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? NumberofBooks { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Status Status { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime? HotFlag { get; set; }
        public int? ViewCount { get; set; }

       /* public virtual Author Author { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }*/
    }
}
