using System;
using System.Collections;


namespace TurboCollections
{
    public class TurboQueue<T>
    {
        private int IndexNumber;
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

        // public T Peek(int AmountOfQueseBeforeYou)
        // {
        //     if (Count == 0)
        //     {
        //         throw new SystemException("Stack is Empty");
        //     }
        //     return items[AmountOfQueseBeforeYou-Count];
        // }
        public T Peek()
        {
            if (Count == 0)
                throw new SystemException("Stack is Empty");
            
            foreach (var item in items)
            {
                for (int i = IndexNumber; i < Count + IndexNumber; i++)
                {
                    items[i - IndexNumber] = items[i];
                }
            }

            return items[IndexNumber];
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


        public T Dequeue()
        {
            if (Count == 0)
                throw new SystemException("Stack is Empty");
            T itemreturn = items[IndexNumber];
            items[IndexNumber] = default(T);
            IndexNumber++;
            return itemreturn;

        }

        public void Clear()
        {
            IndexNumber = 0;
            Count = 0;
            items = Array.Empty<T>();
        }
    }
}