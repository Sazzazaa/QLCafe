using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using DAL.Models;

namespace CafeManagement.DAL
{
    public class OrderDetailDAL
    {

        public OrderDetail GetOrderDetailById(int id)
        {
            using (var db = new Cafe())
            {
                return db.OrderDetails.FirstOrDefault(od => od.OrderDetailID == id);
            }
        }

        public bool InsertOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var db = new Cafe())
                {
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var db = new Cafe())
                {
                    var existing = db.OrderDetails.FirstOrDefault(od => od.OrderDetailID == orderDetail.OrderDetailID);
                    if (existing == null) return false;

                    existing.ProductSizeID = orderDetail.ProductSizeID;
                    existing.OrderID = orderDetail.OrderID;
                    existing.Quantity = orderDetail.Quantity;

                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteOrderDetail(int id)
        {
            try
            {
                using (var db = new Cafe())
                {
                    var existing = db.OrderDetails.FirstOrDefault(od => od.OrderDetailID == id);
                    if (existing == null) return false;

                    db.OrderDetails.Remove(existing);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            using (var db = new Cafe())
            {
                return db.OrderDetails.Where(od => od.OrderID == orderId).ToList();
            }
        }
        public List<object> GetOrderDetailsLight()
        {
            using (var db = new Cafe())
            {
                var data = db.OrderDetails
                             .Select(od => new
                             {
                                 od.OrderDetailID,
                                 od.OrderID,
                                 od.ProductSizeID,
                                 od.Quantity
                             })
                             .ToList();

                return data.Cast<object>().ToList();
            }
        }

    }
}