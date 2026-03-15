using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace New_Learning
{
     public class Storage<T>
    {
       /* public T? Item { get; set; }*/
        List<T> _items = new List<T>();
        /*public void PrintItem()
        {
            
            Console.WriteLine(Item);
        }*/
        public void AddItem(T item)
        {
            _items.Add(item);
        }
        public void RemoveItem(T item)
        {
            _items.Remove(item);
        }
        public void PrintALl()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
