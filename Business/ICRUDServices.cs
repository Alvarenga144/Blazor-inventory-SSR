using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ICRUDServices<T>
    {
        List<T> ItemList();
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
    }
}
