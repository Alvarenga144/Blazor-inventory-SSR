using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Category : ICRUDServices<CategoryEntity>
    {
        public List<CategoryEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateItem(CategoryEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(CategoryEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }

        public void DeleteItem(CategoryEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
