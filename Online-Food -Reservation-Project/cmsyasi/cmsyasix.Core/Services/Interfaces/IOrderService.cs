using cmsyasix.Core.DTOs;
using cmsyasix.Data.Entities.Food;
using cmsyasix.Data.Entities.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace cmsyasix.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int foodId);

        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string username, int orderid);
        bool FinalyOrder(string username, int orderid);
        int DeleteOrder(int productid);
        int updowncount(int productid, string Command);
        List<Order> GetUserOrders(string username);
        Order GetOrderById(int orderid);
        void UpdateOrder(Order order);
        List<Order> GetAllOrder();
        #region Discount
        DiscountUseType UseDiscount(int orderid, string code);
        void AddDiscount(Discount discount);
        List<Discount> GetAllDiscounts();
        Discount GetDiscountById(int disId);
        void UpdateDiscount(Discount discount);
        bool ExistCode(string code);
        void AddInformationUserForSendProduct(SendProduct send);
        #endregion
    }
}
