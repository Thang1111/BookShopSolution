using System;
using System.Collections.Generic;

#nullable disable

namespace BookShopSolution.Data.Entities
{
    public partial class UserGroup
    {
        /*public UserGroup()
        {
            Users = new HashSet<User>();
        }*/

        public string Id { get; set; }
        public string Name { get; set; }

       /* public virtual ICollection<User> Users { get; set; }*/
    }
}
