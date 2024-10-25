using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product : ICRUDServices<ProductEntity>
    {
        public List<ProductEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public void CreateItem(ProductEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(ProductEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(item);
                db.SaveChanges();
            }
        }

        public void DeleteItem(ProductEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
