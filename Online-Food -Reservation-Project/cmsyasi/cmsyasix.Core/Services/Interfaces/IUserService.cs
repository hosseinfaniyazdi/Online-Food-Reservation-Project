using cmsyasix.Core.DTOs;
using cmsyasix.Data.Entities.User;
using cmsyasix.Data.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmsyasix.Core.Services.Interfaces
{
   public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        bool ActiveAccount(string activeCode);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string ActiveCode);
        void UpdateUser(User user);
        User GetUserByUserName(string username);
        int GetUserIdByUserName(string username);
        User GetUserById(int userId);
        void DeleteUser(int userId);
        List<User> GetAllUser();
 
        #region User Panel
        UserPanelViewModel GetUserInformation(string username);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);
        EditProfileViewModel GetDataForEditProfileUser(string username);
        void EditProfile(string username, EditProfileViewModel profile);
        bool CompareOldPassword(string oldPassword, string username);
        void ChangeUserPassword(string userName, string newPassword);
        UserPanelViewModel GetUserInformation(int userId);
        #endregion

        #region Wallet
        int BalanceUserWallet(string username);
        List<WalletViewModel> GetWalletUser(string username);
        int ChargeWallet(string username,int amount,string description, bool ispay=false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);
        #endregion

        #region Admin Panel

        UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);
        UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");

        #endregion
    }
}
