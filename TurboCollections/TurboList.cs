﻿using System;

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

        public T Get(int index)
        {
            return items[index];
        }
    }
}