using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.Food;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cmsyasix.web.Pages.Admin.Foods
{
    [PermissionChecker(12)]
    public class CreateFoodModel : PageModel
    {
        private IFoodService _foodService;

        public CreateFoodModel(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [BindProperty]
        public Food Food { get; set; }

        public void OnGet()
        {
            var groups = _foodService.GetGroupForManageFood();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var subGrous = _foodService.GetSubGroupForManageFood(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subGrous, "Value", "Text");

            var users = _foodService.GetUsers();
            ViewData["Users"] = new SelectList(users, "Value", "Text");

        }
        public IActionResult OnPost(IFormFile imgFoodUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _foodService.AddFood(Food, imgFoodUp);
            return RedirectToPage("Index");
        }
    }
}