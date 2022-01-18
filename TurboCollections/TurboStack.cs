using System;
using System.Collections;
using System.Collections.Generic;

namespace TurboCollections
{
    public class TurboStack<T>
    {
        // public int Count => items.Length;
        // private T[] items = Array.Empty<T>();

        private T[] items = new T[2];

        public int Count
        {
            get;
            private set;
        }
        
        public void Push(T item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        void Resize()
        {
            var result = new T[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                result[i] = items[i];
            }

            items = result;
        }
    }
   
}