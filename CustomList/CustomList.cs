using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustList<T>
    {
        private int count;
        private int capacity;
        private T[] _items;
        //properties and indexer
        public int Count { get => count; }
        public int Capacity { get => capacity; }
        public T this[int index] { get => _items[index]; set => _items[index] = value; }


        public CustList()
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
            for (int i = 0; i < count; i++)
            {
                T item = _items[i];

                if (item.Equals(itemToRemove) && first == true)
                {
                    
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
            if (first == false)
            {
                count--;
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

        public static CustList<T> operator +(CustList<T> list1, CustList<T> list2)
        {
            CustList<T> list3 = new CustList<T>();
            
            for (int i = 0; i < list1.count; i++)
            {
                T item = list1[i];
                list3.Add(item);
            }
            for (int i = 0; i < list2.count; i++)
            {
                T item = list2[i];
                list3.Add(item);
            }
            
            return list3;
        }

        public static CustList<T> operator -(CustList<T> list1, CustList<T> list2)
        {
            

            for (int i = 0; i < list2.count; i++)
            {
                list1.Remove(list2[i]);
            }
            return list1;
        }

        public CustList<T> Zip(CustList<T> list2)
        {
            CustList<T> list3 = new CustList<T>();
            while (list3.Count < (count + list2.count))
            {
                for (int i = 0; i < count; i++)
                {
                    list3.Add(_items[i]);
                    list3.Add(list2[i]);
                }
                
            }
            return list3;
        }
    }
}
