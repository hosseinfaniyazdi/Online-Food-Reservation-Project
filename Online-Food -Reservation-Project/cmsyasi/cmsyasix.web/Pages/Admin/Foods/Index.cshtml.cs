using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.DTOs;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin.Foods
{
    [PermissionChecker(11)]
    public class IndexModel : PageModel
    {
        private IFoodService _foodService;

        public IndexModel(IFoodService foodService)
        {
            _foodService = foodService;
        }
        public List<ShowFoodForAdminViewModel> ListFood { get; set; }
        public void OnGet()
        {
            ListFood = _foodService.GetFoodForAdmin();
        }
    }
}