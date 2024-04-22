using cmsyasix.Core.DTOs;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Context;
using cmsyasix.Data.Entities.Food;
using cmsyasix.Data.Entities.Order;
using cmsyasix.Data.Entities.User;
using cmsyasix.Data.Entities.Wallet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cmsyasix.Core.Services
{
    public class OrderService:IOrderService
    {
        private cmsyasixContex _context;
        private IUserService _userService;

        public OrderService(cmsyasixContex context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public void AddDiscount(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();
        }

        public void AddInformationUserForSendProduct(SendProduct send)
        {
            _context.SendProducts.Add(send);
            _context.SaveChanges();
        }

        public int AddOrder(string userName, int foodId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            Order order = _context.Orders
                .FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var food = _context.Foods.Find(foodId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = food.FoodPrice,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            ProductId = foodId,
                            Count = 1,
                            Price = food.FoodPrice
                        }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails
                    .FirstOrDefault(d => d.OrderId == order.OrderId && d.ProductId == foodId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        ProductId = foodId,
                        Price = food.FoodPrice,
                    };
                    _context.OrderDetails.Add(detail);
                }

                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }


            return order.OrderId;

        }

        public int DeleteOrder(int productid)
        {
            var orderdetail = _context.OrderDetails.Find(productid);
            int orderid = orderdetail.OrderId;
            _context.OrderDetails.Remove(orderdetail);
            _context.SaveChanges();
            UpdatePriceOrder(orderid);
            return orderid;
        }

        public bool ExistCode(string code)
        {
            return _context.Discounts.Any(d => d.DiscountCode == code);
        }

        public bool FinalyOrder(string username, int orderid)
        {
            int userid = _userService.GetUserIdByUserName(username);
            var order = _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Food)
                .FirstOrDefault(o => o.OrderId == orderid && o.UserId == userid);
            if (order == null || order.IsFinaly)
            {
                return false;
            }

            if (_userService.BalanceUserWallet(username) >= order.OrderSum)
            {
                order.IsFinaly = true;
                _userService.AddWallet(new Wallet()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتور شما #" + order.OrderId,
                    UserId = userid,
                    TypeId = 2
                });
                _context.Orders.Update(order);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Discount> GetAllDiscounts()
        {
            return _context.Discounts.ToList();
        }

        public List<Order> GetAllOrder()
        {
            return _context.Orders.ToList();

        }

        public Discount GetDiscountById(int disId)
        {
            return _context.Discounts.Find(disId);
        }

        public Order GetOrderById(int orderid)
        {
            return _context.Orders.Find(orderid);
        }

        public Order GetOrderForUserPanel(string username, int orderid)
        {
            int userid = _userService.GetUserIdByUserName(username);
            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(od=>od.Food)
                .FirstOrDefault(o => o.UserId == userid && o.OrderId == orderid);
        }

        public List<Order> GetUserOrders(string username)
        {
            int userid = _userService.GetUserIdByUserName(username);
            return _context.Orders.Where(o => o.UserId == userid).ToList();
        }

        public void UpdateDiscount(Discount discount)
        {
            _context.Discounts.Update(discount);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price * d.Count);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public int updowncount(int productid, string Command)
        {
            var orderDetail = _context.OrderDetails.Find(productid);
            int orderId = orderDetail.OrderId;

            switch (Command)
            {
                case "up":
                    {
                        orderDetail.Count += 1;
                        _context.Update(orderDetail);
                        break;
                    }
                case "down":
                    {
                        orderDetail.Count -= 1;
                        if (orderDetail.Count == 0)
                        {
                            _context.OrderDetails.Remove(orderDetail);
                        }
                        else
                        {
                            _context.Update(orderDetail);
                        }

                        break;
                    }
            }


            _context.SaveChanges();
            UpdatePriceOrder(orderId);
            return orderId;
        }

        public DiscountUseType UseDiscount(int orderid, string code)
        {
            var discount = _context.Discounts.SingleOrDefault(d => d.DiscountCode == code);

            if (discount == null)
                return DiscountUseType.NotFound;

            if (discount.StartDate != null && discount.StartDate < DateTime.Now)
                return DiscountUseType.ExpierDate;

            if (discount.EndDate != null && discount.EndDate >= DateTime.Now)
                return DiscountUseType.ExpierDate;


            if (discount.UsableCount != null && discount.UsableCount < 1)
                return DiscountUseType.Finished;

            var order = GetOrderById(orderid);
            if (_context.UserDiscounts.Any(d => d.UserId == order.UserId && d.DiscountId == discount.DiscountId))
            {
                return DiscountUseType.Used;
            }

            int percent = (order.OrderSum * discount.DiscountPercent) / 100;
            order.OrderSum = order.OrderSum - percent;

            UpdateOrder(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _context.Discounts.Update(discount);
            _context.UserDiscounts.Add(new UserDiscount()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });
            _context.SaveChanges();



            return DiscountUseType.Success;
        }
    }
}
