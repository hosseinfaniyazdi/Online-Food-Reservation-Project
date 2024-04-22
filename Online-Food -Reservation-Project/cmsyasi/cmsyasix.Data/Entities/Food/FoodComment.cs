using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cmsyasix.Data.Entities.Food
{
    public class FoodComment
    {
        [Key]
        public int CommentId { get; set; }
        public int FoodId { get; set; }
        public int UserId { get; set; }

        [MaxLength(700)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAdminRead { get; set; }


        public Food Food { get; set; }
        public User.User User { get; set; }
    }
}
