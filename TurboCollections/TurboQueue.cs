using System;
using System.Collections;


namespace TurboCollections
{
    public class TurboQueue<T>
    {
        private T[] items = new T[2];
        public int Count
        {
            get;
            private set;
        }

        public void EnQueue(T item)
        {
            if (Count== items.Length)
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