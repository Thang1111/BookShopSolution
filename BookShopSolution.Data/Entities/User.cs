using BookShopSolution.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class User
    {
        /*public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
        }*/

        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string GroupId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Status Status { get; set; }

        /*public virtual UserGroup Group { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }*/
    }
}
