using System;
using System.Collections.Generic;
using CafeManagement.DAL;
using DAL.Models;

namespace CafeManagement.BLL
{
    public class OrderBLL
    {
        private OrderDAL orderDAL = new OrderDAL();


        public Order GetOrderById(int orderId)
        {
            return orderDAL.GetOrderById(orderId);
        }

        public bool InsertOrder(Order order)
        {
            return orderDAL.InsertOrder(order);
        }

        public bool UpdateOrder(Order order)
        {
            return orderDAL.UpdateOrder(order);
        }

        public bool DeleteOrder(int orderId)
        {
            return orderDAL.DeleteOrder(orderId);
        }

        public List<Order> SearchOrdersByDate(DateTime fromDate, DateTime toDate)
        {
            return orderDAL.SearchOrdersByDate(fromDate, toDate);
        }

        public List<Order> SearchOrdersAdvanced(string status, string tableId)
        {
            return orderDAL.SearchOrdersAdvanced(status, tableId);
        }
        public List<object> GetOrdersLight()
        {
            return orderDAL.GetOrdersLight();
        }
        public List<object> SearchOrdersByDateLight(DateTime fromDate, DateTime toDate)
        {
            return orderDAL.SearchOrdersByDateLight(fromDate, toDate);
        }

    }
}