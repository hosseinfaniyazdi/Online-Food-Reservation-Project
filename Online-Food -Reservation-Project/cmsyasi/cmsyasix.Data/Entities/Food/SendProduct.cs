using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cmsyasix.Data.Entities.Food
{
    public class SendProduct
    {
        [Key]
        public int SPId { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string userNm { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(700, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public string PhoneNumber { get; set; }

        #region Relation
        public Order.Order Order { get; set; }
        public User.User User { get; set; }
        #endregion
    }
}
