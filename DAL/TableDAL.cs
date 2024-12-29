using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class TableDAL
    {
        private Cafe db = new Cafe();

        public List<dynamic> GetAllTables()
        {
            var cf_table = from cf in db.CF_Table
                           join a in db.Areas on cf.AreaID equals a.AreaID
                           select new
                           {
                               TableID = cf.TableID,
                               TableName = cf.TableName,
                               AreaName = a.AreaName
                           }; return cf_table.ToList<dynamic>();
        }

        public CF_Table GetTableById(string tableId)
        {
            return db.CF_Table.FirstOrDefault(t => t.TableID == tableId);
        }

        public void AddTable(CF_Table table)
        {
            db.CF_Table.Add(table);
            db.SaveChanges();
        }

        public void UpdateTable(CF_Table table)
        {
            var existingTable = db.CF_Table.FirstOrDefault(t => t.TableID == table.TableID);
            if (existingTable != null)
            {
                existingTable.TableName = table.TableName;
                existingTable.AreaID = table.AreaID;
                db.SaveChanges();
            }
        }

        public void DeleteTable(string tableId)
        {
            var table = db.CF_Table.FirstOrDefault(t => t.TableID == tableId);
            if (table != null)
            {
                db.CF_Table.Remove(table);
                db.SaveChanges();
            }
        }

    }
}
