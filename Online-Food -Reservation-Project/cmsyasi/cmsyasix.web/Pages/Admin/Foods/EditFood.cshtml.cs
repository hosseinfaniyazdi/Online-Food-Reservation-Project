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
    [PermissionChecker(13)]
    public class EditFoodModel : PageModel
    {
        private IFoodService _foodService;

        public EditFoodModel(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [BindProperty]
        public Food Food { get; set; }

        public void OnGet(int id)
        {
            Food = _foodService.GetfoodById(id);
            var groups = _foodService.GetGroupForManageFood();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text",Food.FoodId);

            List<SelectListItem> subgroups = new List<SelectListItem>()
            {
                new SelectListItem(){Text="انتخاب کنید" , Value=""}
            };
            subgroups.AddRange(_foodService.GetSubGroupForManageFood(Food.GroupId));
            string selectedsubgp = null;
            if (Food.SubGroup!=null)
            {
                selectedsubgp = Food.SubGroup.ToString();
            }
            ViewData["SubGroups"] = new SelectList(subgroups, "Value", "Text",selectedsubgp);

            var users = _foodService.GetUsers();
            ViewData["Users"] = new SelectList(users, "Value", "Text",Food.UserId);

        }
        public IActionResult OnPost(IFormFile imgFoodUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _foodService.UpdateFood(Food, imgFoodUp);
            return RedirectToPage("Index");
        }
    }
}