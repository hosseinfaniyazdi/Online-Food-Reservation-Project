using cmsyasix.Data.Entities.Permission;
using cmsyasix.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmsyasix.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Roles

        List<Role> GetRoles();
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);

        #endregion
        #region Permission
        List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permissions);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId,List<int> permissions);
        bool UserCheckPermission(int permissionId, string username);
        #endregion
    }
}
