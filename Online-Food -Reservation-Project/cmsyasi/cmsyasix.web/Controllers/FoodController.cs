using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.Food;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cmsyasix.web.Controllers
{
    public class FoodController : Controller
    {
        private IFoodService _foodService;
        private IOrderService _orderService;
        private IUserService _userService;
        public FoodController(IFoodService foodService, IOrderService orderService, IUserService userService)
        {
            _foodService = foodService;
            _orderService = orderService;
            _userService = userService;
        }
        public IActionResult Index(int pageid=1, string filter = "", string orderbytype = "date", int startprice = 0, int endprice = 0, List<int> selectedgroups = null)
        {
            ViewBag.selectedGroups = selectedgroups;
            ViewBag.Groups = _foodService.GetAllGroup();
            ViewBag.pageId = pageid;
            return View(_foodService.GetFood(pageid,filter,orderbytype,startprice,endprice,selectedgroups,9));
        }

        [Route("ShowFood/{id}")]
        public IActionResult ShowFood(int id)
        {
            var food = _foodService.GetFoodForShow(id);
            if (food==null)
            {
                return NotFound();
            }
            return View(food);
        }
        [Authorize]
        public IActionResult BuyFood(int id)
        {
            int orderid = _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderid);
        }


        [HttpPost]
        public IActionResult CreateComment(FoodComment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userService.GetUserIdByUserName(User.Identity.Name);
            _foodService.AddComment(comment);

            return View("ShowComment", _foodService.GetFoodComment(comment.FoodId));
        }

        public IActionResult ShowComment(int id, int pageId=1)
        {
            return View(_foodService.GetFoodComment(id, pageId));

        }
    }
}