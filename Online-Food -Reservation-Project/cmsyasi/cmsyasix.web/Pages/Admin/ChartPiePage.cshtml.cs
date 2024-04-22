using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin
{
    public class ChartPiePageModel : PageModel
    {
        private IUserService _userservice;
        private IOrderService _orderservice;
        public ChartPiePageModel(IUserService userservice, IOrderService orderservice)
        {
            _userservice = userservice;
            _orderservice = orderservice;
        }
        public void OnGet()
        {
            ViewData["ListOrder"] = _orderservice.GetAllOrder();
        }
    }
}
