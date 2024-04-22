using cmsyasix.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cmsyasix.web.Components
{
    public class FoodGroupComponent:ViewComponent
    {
        private IFoodService FoodService;
        public FoodGroupComponent(IFoodService _foodService)
        {
            FoodService = _foodService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("FoodGroup", FoodService.GetAllGroup()));
        }
    }
}
