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
        public int Count;
        public int Capacity;
        

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
            Count = _items.Length;
            Capacity = capacity;
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
               capacity = capacity * 2;
               T[] _items2 = new T[capacity];

                for (int i = 0; i < _items.Count(); i++)
                {
                    T item = _items[i];
                    _items2[count] = item;
                }
                _items = _items2;
                
            }
            _items[count] = itemToAdd;
            count++;
        }

        public void Remove()
        {

        }
    }
}
