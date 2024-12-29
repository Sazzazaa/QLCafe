using System.Collections.Generic;
using CafeManagement.DAL;
using DAL.Models;

namespace CafeManagement.BLL
{
    public class OrderDetailBLL
    {
        private OrderDetailDAL orderDetailDAL = new OrderDetailDAL();


        public OrderDetail GetOrderDetailById(int id)
        {
            return orderDetailDAL.GetOrderDetailById(id);
        }

        public bool InsertOrderDetail(OrderDetail orderDetail)
        {
            return orderDetailDAL.InsertOrderDetail(orderDetail);
        }

        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            return orderDetailDAL.UpdateOrderDetail(orderDetail);
        }

        public bool DeleteOrderDetail(int id)
        {
            return orderDetailDAL.DeleteOrderDetail(id);
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return orderDetailDAL.GetOrderDetailsByOrderId(orderId);
        }
        public List<object> GetOrderDetailsLight()
        {
            return orderDetailDAL.GetOrderDetailsLight();
        }

    }
}