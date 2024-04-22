using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin.Roles
{
    [PermissionChecker(8)]
    public class EditRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public EditRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionService.GetRoleById(id);
            ViewData["Permissions"] = _permissionService.GetAllPermission();
            ViewData["SelectedPermissions"] = _permissionService.PermissionsRole(id);
        }

        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();


            _permissionService.UpdateRole(Role);

            //Add Permission
            _permissionService.UpdatePermissionsRole(Role.RoleId, SelectedPermission);

            return RedirectToPage("Index");
        }
    }
}