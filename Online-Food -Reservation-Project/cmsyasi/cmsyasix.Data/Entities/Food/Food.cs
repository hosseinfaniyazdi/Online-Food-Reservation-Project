using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cmsyasix.Data.Entities.Food
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        public int GroupId { get; set; }

        public int? SubGroup { get; set; }

        [Display(Name = "عنوان دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string FoodTitle { get; set; }

        [Display(Name = "شرح دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string FoodDescription { get; set; }

        [Display(Name = "قیمت دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int FoodPrice { get; set; }

        [MaxLength(600)]
        public string Tags { get; set; }

        [MaxLength(50)]
        public string FoodImageName { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public int UserId { get; set; }

        #region Relation
        public User.User User { get; set; }

        [ForeignKey("GroupId")]
        public FoodGroup FoodGroup { get; set; }

        [ForeignKey("SubGroup")]
        public FoodGroup food { get; set; }

        public List<Order.OrderDetail> OrderDetails { get; set; }
        public List<FoodComment> FoodComments { get; set; }
        #endregion
    }
}
