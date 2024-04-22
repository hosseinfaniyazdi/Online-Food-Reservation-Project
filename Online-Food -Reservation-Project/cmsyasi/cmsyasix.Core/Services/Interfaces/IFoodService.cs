using cmsyasix.Core.DTOs;
using cmsyasix.Data.Entities.Food;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmsyasix.Core.Services.Interfaces
{
    public interface IFoodService
    {
        #region Group

        List<FoodGroup> GetAllGroup();
        List<SelectListItem> GetGroupForManageFood();
        List<SelectListItem> GetSubGroupForManageFood(int groupId);
        List<SelectListItem> GetUsers();


        #endregion

        #region Food
        int AddFood(Food food, IFormFile imgFood);
        List<ShowFoodForAdminViewModel> GetFoodForAdmin();
        Food GetfoodById(int foodId);
        void UpdateFood(Food food, IFormFile imgFood);
        Tuple<List<ShowFoodListViewModel>,int> GetFood(int pageId = 1, string filter = "", string orderbytype = "date", int startprice = 0, int endprice = 0, List<int> selectedgroups = null, int take = 0);
        Food GetFoodForShow(int foodId);
        List<ShowFoodListViewModel> GetPopularFood();
        void AddGroup(FoodGroup foodGroup);
        void UpdateGroup(FoodGroup foodGroup);
        FoodGroup GetById(int foodid);
        #endregion

        #region Comment
        void AddComment(FoodComment comment);
        Tuple<List<FoodComment>, int> GetFoodComment(int foodid, int pageId = 1);
        #endregion
    }
}
