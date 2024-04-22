using cmsyasix.Data.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cmsyasix.Data.Entities.User
{
    public class UserDiscount
    {
        [Key]
        public int UD_Id { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }


        public User User { get; set; }
        public Discount Discount { get; set; }
    }
}
