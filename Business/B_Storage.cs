using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage : ICRUDServices<StorageEntity>
    {
        public List<StorageEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateItem(StorageEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(StorageEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }

        public void DeleteItem(StorageEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
