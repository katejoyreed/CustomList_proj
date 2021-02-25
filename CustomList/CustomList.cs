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

            bool first = true;
            for (int i = 0; i < count + 1; i++)
            {
                T item = _items[i];

                if (item.Equals(itemToRemove) && first == true)
                {
                    count--;
                    first = false;
                }
                else if (!item.Equals(itemToRemove) || first == false)
                {
                    if (first == true)
                    {
                        _items2[i] = item;
                    }
                    else if (first == false)
                    {
                        _items2[i - 1] = item;
                    }


                }
            }
            _items = _items2;
        }

        public override string ToString()
        {

            string[] _items2 = new string[capacity];
            for (int i = 0; i < count; i++)
            {
                string _item = $"{_items[i]}";
                _items2[i] = _item;
            }
            string finalString = String.Join(", ", _items2.Where(s => !string.IsNullOrEmpty(s)));
            return finalString;
        }

        public static T[] PlusOperator()
        {

        }
    }
}
