using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public int? GroupId { get; set; }
        public string Target { get; set; }
        public Status Status { get; set; }

        /*public virtual MenuGroup Group { get; set; }*/
    }
}
