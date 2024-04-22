using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.DTOs;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin.Users
{
    [PermissionChecker(5)]
    public class DeleteUserModel : PageModel
    {
        private IUserService _userService;

        public DeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserPanelViewModel UserPanelViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["UserId"] = id;
            UserPanelViewModel = _userService.GetUserInformation(id);
        }

        public IActionResult OnPost(int UserId)
        {
            _userService.DeleteUser(UserId);
            return RedirectToPage("Index");
        }
    }
}