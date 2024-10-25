using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput : ICRUDServices<InputOutputEntity>
    {
        public List<InputOutputEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateItem(InputOutputEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateItem(InputOutputEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(item);
                db.SaveChanges();
            }
        }

        public void DeleteItem(InputOutputEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
