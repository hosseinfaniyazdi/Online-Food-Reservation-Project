using cmsyasix.Core.Convertors;
using cmsyasix.Core.DTOs;
using cmsyasix.Core.Generator;
using cmsyasix.Core.Security;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Context;
using cmsyasix.Data.Entities.Food;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cmsyasix.Core.Services
{
    public class FoodService : IFoodService
    {
        private cmsyasixContex _context;

        public FoodService(cmsyasixContex context)
        {
            _context = context;
        }

        public void AddComment(FoodComment comment)
        {
            _context.FoodComments.Add(comment);
            _context.SaveChanges();
        }

        public int AddFood(Food food, IFormFile imgFood)
        {
            food.CreateDate = DateTime.Now;
            food.FoodImageName = "no-photo.jpg";
            //Check Image
            if (imgFood != null && imgFood.IsImage())
            {
                food.FoodImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgFood.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/image", food.FoodImageName); ;
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgFood.CopyTo(stream);
                }

                // Image Resize
                ImageConvertor imgresizer = new ImageConvertor();
                ImageToBinary imgbin = new ImageToBinary();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/thumb", food.FoodImageName);
                string binpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/binpic/binpic.bin");
                imgresizer.Image_resize(imagePath, thumbPath, 150);
                System.IO.File.WriteAllBytes(binpath,imgbin.ImgToBinary(imagePath));
            }

            _context.Add(food);
            _context.SaveChanges();
            return food.FoodId;
        }

        public void AddGroup(FoodGroup foodGroup)
        {
             _context.FoodGroups.Add(foodGroup);
            _context.SaveChanges();
        }

        public List<FoodGroup> GetAllGroup()
        {
            return _context.FoodGroups.Include(c=>c.FoodGroups).ToList();
        }

        public FoodGroup GetById(int foodid)
        {
            return _context.FoodGroups.Find(foodid);
        }

        public Tuple<List<ShowFoodListViewModel>, int> GetFood(int pageId = 1, string filter = "", string orderbytype = "date", int startprice = 0, int endprice = 0, List<int> selectedgroups = null, int take = 0)
        {
            if (take == 0)
            {
                take = 8;
            }
            IQueryable<Food> res = _context.Foods;
            if (!string.IsNullOrEmpty(filter))
            {
                res = res.Where(c => c.FoodTitle.Contains(filter) || c.Tags.Contains(filter));
            }
            switch (orderbytype)
            {
                case "date":
                    {
                        res = res.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "Price":
                    {
                        res = res.OrderByDescending(c => c.FoodPrice);
                        break;
                    }
            }
            if (startprice > 0)
            {
                res = res.Where(c => c.FoodPrice > startprice);
            }
            if (endprice > 0)
            {
                res = res.Where(c => c.FoodPrice < endprice);
            }

            if (selectedgroups!=null&&selectedgroups.Any())
            {
                foreach (int groupid in selectedgroups)
                {
                    res = res.Where(f => f.GroupId == groupid || f.SubGroup == groupid);
                }
            }
            //Do Paging
            int skip = (pageId - 1) * take;

            int pagecount = res.Select(f => new ShowFoodListViewModel()
            {
                FoodId = f.FoodId,
                ImageName = f.FoodImageName,
                Price = f.FoodPrice,
                Title = f.FoodTitle
            }).Count() / take;

            var query = res.Select(f => new ShowFoodListViewModel()
            {
                FoodId = f.FoodId,
                ImageName = f.FoodImageName,
                Price = f.FoodPrice,
                Title = f.FoodTitle
            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pagecount);
        }

        public Food GetfoodById(int foodId)
        {
            return _context.Foods.Find(foodId);
        }

        public Tuple<List<FoodComment>, int> GetFoodComment(int foodid, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.FoodComments.Where(c => !c.IsDelete && c.FoodId == foodid).Count() / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.FoodComments.Include(c => c.User).Where(c => !c.IsDelete && c.FoodId == foodid).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);
        }

        public List<ShowFoodForAdminViewModel> GetFoodForAdmin()
        {
            return _context.Foods.Select(f => new ShowFoodForAdminViewModel()
            {
                FoodId = f.FoodId,
                ImageName = f.FoodImageName,
                Title = f.FoodTitle
            }).ToList();
        }

        public Food GetFoodForShow(int foodId)
        {
            return _context.Foods.Include(f=>f.OrderDetails).FirstOrDefault(f => f.FoodId == foodId);
        }

        public List<SelectListItem> GetGroupForManageFood()
        {
            return _context.FoodGroups.Where(g => g.ParentId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<ShowFoodListViewModel> GetPopularFood()
        {
            return _context.Foods.Include(c => c.OrderDetails)
                .Where(c=>c.OrderDetails.Any())
                .OrderByDescending(d => d.OrderDetails.Count)
                .Take(8).Select(c => new ShowFoodListViewModel()
                {
                    FoodId = c.FoodId,
                    ImageName = c.FoodImageName,
                    Price = c.FoodPrice,
                    Title = c.FoodTitle
                }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageFood(int groupId)
        {
            return _context.FoodGroups.Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetUsers()
        {
            return _context.UserRoles.Where(r => r.RoleId == 1).Include(r => r.User)
                .Select(u => new SelectListItem()
                {
                    Value = u.UserId.ToString(),
                    Text = u.User.UserName
                }).ToList();
        }

        public void UpdateFood(Food food, IFormFile imgFood)
        {
            if (imgFood != null && imgFood.IsImage())
            {
                if (food.FoodImageName != "no-photo.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/image", food.FoodImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/thumb", food.FoodImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                food.FoodImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgFood.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/image", food.FoodImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgFood.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/food/thumb", food.FoodImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }

            _context.Foods.Update(food);
            _context.SaveChanges();
        }

        public void UpdateGroup(FoodGroup foodGroup)
        {
            _context.FoodGroups.Update(foodGroup);
            _context.SaveChanges();
        }
    }
}
