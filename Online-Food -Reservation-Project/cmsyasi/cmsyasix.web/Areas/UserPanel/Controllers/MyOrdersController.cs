using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Convertors;
using cmsyasix.Core.DTOs;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.Food;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cmsyasix.web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class MyOrdersController : Controller
    {
        private IOrderService _orderService;
        public MyOrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {

            return View(_orderService.GetUserOrders(User.Identity.Name));
        }
        public IActionResult ShowOrder(int id, bool finaly = false, string type="")
        {
            var order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);

            if (order == null)
            {
                return NotFound();
            }
            ViewBag.DiscountType = type;
            ViewBag.finaly = finaly;
            return View(order);
        }

        public IActionResult FinalyOrder(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {
                return Redirect("/UserPanel/MyOrders/ShowOrder/" + id + "?finaly=true");
            }

            return BadRequest();
        }
        public IActionResult Delete(int id)
        {
            int orderId = _orderService.DeleteOrder(id);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }
        public IActionResult Command(int id, string command)
        {
            int orderId = _orderService.updowncount(id, command);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }

        public IActionResult UseDiscount(int orderid,string code)
        {
            DiscountUseType Type = _orderService.UseDiscount(orderid, code);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderid + "?type=" + Type.ToString());
        }
        public IActionResult SendPd(SendProduct sendProduct)
        {
            if (!ModelState.IsValid)
                return View(sendProduct);
            sendProduct.CreateDate = DateTime.Now;
            _orderService.AddInformationUserForSendProduct(sendProduct);
            return PartialView("_SendPro", sendProduct);
        }
    }
}