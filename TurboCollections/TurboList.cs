using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TurboCollections
{
    public class TurboList<T>
    {
        public int Count => items.Length;
        private T[] items = Array.Empty<T>();
        public TurboList()
        {
            Console.WriteLine("Hello Turbo!");
        }

        public void Add(T item)
        {
            // Resize the Array
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            
            //Assign the new Element
            newArray[Count] = item;
            
            
            items = newArray;
        }
        
//         void Clear();
// removes all items from the list.

        public void Clear()
        {
            items = Array.Empty<T>();
            
        }

        public T Get(int index)
        {
            return items[index];
        }

        public void ClearSpecifed(int index)
        {
            if (index > Count || index < 0)
                throw new System.Exception("Requested index was out of range of the list!");

            var result = new T[Count - 1];
            var currentIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                if (i != index)
                {
                    result[currentIndex] = items[i];
                    currentIndex++;
                }
            }


            items = result;
        }
        public bool Contains(T searchItem)
        {
            return IndexOf(searchItem) != -1;
        }
        // returns the index of the given item if it is in the list, else -1.
        public int IndexOf(T searchItem)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(searchItem))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Set(int index,T item)
        {
            items[index] = item;
        }
    }
}