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
    [PermissionChecker(1016)]
    public class EditGroupModel : PageModel
    {
        private IFoodService _foodService;
        public EditGroupModel(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [BindProperty]
        public FoodGroup foodGroups { get; set; }

        public void OnGet(int id)
        {
            foodGroups = _foodService.GetById(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _foodService.UpdateGroup(foodGroups);

            return RedirectToPage("Index");
        }
    }
}
