using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.Food;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin.FoodGroups
{
    [PermissionChecker(1014)]
    public class IndexModel : PageModel
    {
        private IFoodService _foodService;
        public IndexModel(IFoodService foodService)
        {
            _foodService = foodService;
        }
        public List<FoodGroup> FoodGroups { get; set; }
        public void OnGet()
        {
            FoodGroups = _foodService.GetAllGroup();
        }
    }
}
