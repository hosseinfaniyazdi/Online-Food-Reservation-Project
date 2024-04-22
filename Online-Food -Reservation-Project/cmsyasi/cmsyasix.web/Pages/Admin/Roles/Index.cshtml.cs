using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cmsyasix.Core.DTOs;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cmsyasix.web.Pages.Admin.Roles
{
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {       
        private IPermissionService _permissionService;

        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> RolesList { get; set; }


        public void OnGet()
        {
            RolesList = _permissionService.GetRoles();
        }



    }
}