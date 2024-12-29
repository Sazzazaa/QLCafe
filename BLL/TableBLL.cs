using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class TableBLL
    {
        public List<CF_Table> GetAllTables()
        {
            using (var db = new Cafe()) // thay CafeDbContext bằng context của bạn
            {
                return db.CF_Table.ToList(); // hoặc db.Table (tên DbSet) tuỳ cách đặt tên
            }
        }
    }
}