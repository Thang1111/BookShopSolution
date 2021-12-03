using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class Author
    {
        /*public Author()
        {
            Products = new HashSet<Product>();
        }*/

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime? YearofBirth { get; set; }
        public DateTime? YearofDeath { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Status Status { get; set; }

       /* public virtual ICollection<Product> Products { get; set; }*/
    }
}
