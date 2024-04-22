using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin.Discount
{
    [PermissionChecker(1011)]
    public class IndexModel : PageModel
    {
        private IOrderService _orderservice;
        public IndexModel(IOrderService orderService)
        {
            _orderservice = orderService;
        }
        public List<Data.Entities.Order.Discount> Discounts { get; set; }
        public void OnGet()
        {
            Discounts = _orderservice.GetAllDiscounts();
        }
    }
}
