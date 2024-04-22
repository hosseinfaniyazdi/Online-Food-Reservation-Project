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
    [PermissionChecker(4)]
    public class EditUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;

        public EditUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }




        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel = _userService.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _userService.EditUserFromAdmin(EditUserViewModel);

            //Edit Roles
            _permissionService.EditRolesUser(EditUserViewModel.UserId, SelectedRoles);
            return RedirectToPage("Index");
        }
    }
}