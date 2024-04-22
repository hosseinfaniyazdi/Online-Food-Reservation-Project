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
    [PermissionChecker(1015)]
    public class CreateGroupModel : PageModel
    {
        private IFoodService _foodService;
        public CreateGroupModel(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [BindProperty]
        public FoodGroup foodGroups { get; set; }
        public void OnGet(int? id)
        {
            foodGroups = new FoodGroup()
            {
                ParentId = id
            };
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _foodService.AddGroup(foodGroups);
            return RedirectToPage("Index");
        }
    }
}
