using System;
using System.Collections.Generic;
using System.Text;

namespace cmsyasix.Core.DTOs
{
    public class ShowFoodListViewModel
    {
        public int FoodId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }
    }
}
