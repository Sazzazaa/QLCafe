using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using DAL.Models;

namespace CafeManagement.DAL
{
    public class OrderDAL
    {

        public Order GetOrderById(int orderId)
        {
            using (var db = new Cafe())
            {
                return db.Orders.FirstOrDefault(o => o.OrderID == orderId);
            }
        }

        public bool InsertOrder(Order order)
        {
            try
            {
                using (var db = new Cafe())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                using (var db = new Cafe())
                {
                    var existingOrder = db.Orders.FirstOrDefault(o => o.OrderID == order.OrderID);
                    if (existingOrder == null) return false;

                    // Cập nhật các trường cần thiết
                    existingOrder.DateCheckIn = order.DateCheckIn;
                    existingOrder.DateCheckOut = order.DateCheckOut;
                    existingOrder.Status = order.Status;
                    existingOrder.TableID = order.TableID;

                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                using (var db = new Cafe())
                {
                    var existingOrder = db.Orders.FirstOrDefault(o => o.OrderID == orderId);
                    if (existingOrder == null) return false;

                    db.Orders.Remove(existingOrder);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Order> SearchOrdersByDate(DateTime fromDate, DateTime toDate)
        {
            using (var db = new Cafe())
            {
                return db.Orders
                         .Where(o => o.DateCheckIn >= fromDate && o.DateCheckIn <= toDate)
                         .ToList();
            }
        }


        public List<Order> SearchOrdersAdvanced(string status, string tableId)
        {
            using (var db = new Cafe())
            {
                var query = db.Orders.AsQueryable();

                if (!string.IsNullOrEmpty(status))
                {
                    query = query.Where(o => o.Status.Contains(status));
                }
                if (!string.IsNullOrEmpty(tableId))
                {
                    query = query.Where(o => o.TableID.Contains(tableId));
                }

                return query.ToList();
            }
        }
        public List<object> GetOrdersLight()
        {
            using (var db = new Cafe()) // Thay "CafeDbContext" bằng tên DbContext của bạn
            {
                var data = (from o in db.Orders
                            join t in db.CF_Table
                            on o.TableID equals t.TableID
                            select new
                            {
                                o.OrderID,
                                o.DateCheckIn,
                                o.DateCheckOut,
                                o.Status,
                                o.TableID,
                                t.TableName
                            }).ToList();

                return data.Cast<object>().ToList();
            }
        }
        public List<object> SearchOrdersByDateLight(DateTime fromDate, DateTime toDate)
        {
            using (var db = new Cafe())
            {
                var data = db.Orders
                             .Where(o => o.DateCheckIn >= fromDate && o.DateCheckIn <= toDate)
                             .Select(o => new
                             {
                                 o.OrderID,
                                 o.DateCheckIn,
                                 o.DateCheckOut,
                                 o.Status,
                                 o.TableID
                             })
                             .ToList();

                return data.Cast<object>().ToList();
            }
        }

    }
}