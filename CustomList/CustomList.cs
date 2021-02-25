using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;
        private T[] _items;
        //properties and indexer
        public int Count { get => count; }
        public int Capacity { get => capacity; }
        public T this[int index] { get => _items[index]; set => _items[index] = value; }
        

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
            
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
               capacity = capacity * 2;
               T[] _items2 = new T[capacity];
               

                for (int i = 0; i < count; i++)
                {
                    T item = _items[i];
                    _items2[i] = item;
                }
                _items = _items2;
                
            }
            _items[count] = itemToAdd;
            count++;
        }

        public void Remove(T itemToRemove)
        {
            T[] _items2 = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                
                T item = _items[i];

                if (item.Equals(itemToRemove))
                {
                    count--;
                    i--;
                }
                else if (!item.Equals(itemToRemove))
                {
                    _items2[i] = item;
                }
            }
            _items = _items2;
        }
    }
}
