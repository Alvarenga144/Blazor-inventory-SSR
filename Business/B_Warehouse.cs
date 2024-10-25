using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse : ICRUDServices<WarehouseEntity>
    {
        public List<WarehouseEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateItem(WarehouseEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(WarehouseEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(item);
                db.SaveChanges();
            }
        }

        public void DeleteItem(WarehouseEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
