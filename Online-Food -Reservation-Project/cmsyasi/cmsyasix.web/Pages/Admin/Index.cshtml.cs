using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin
{
    [PermissionChecker(1)]
    public class IndexModel : PageModel
    {
        private IUserService _userservice;
        private IOrderService _orderservice;
        public IndexModel(IUserService userservice, IOrderService orderservice)
        {
            _userservice = userservice;
            _orderservice = orderservice;
        }

        public void OnGet()
        {
             


        }
    }
}