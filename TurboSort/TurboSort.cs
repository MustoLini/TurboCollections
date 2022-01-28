using System;
using System.Collections;
using System.Collections.Generic;
using TurboCollections;

namespace TurboSort
{
    public static class TurboSort
    {
        public static TurboList<int> BubbleSort(TurboList<int> items)
        {
            int item;
            // int item = items.Count;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < items.Count-1; i++)
                {
                    if (items.Get(i) > items.Get(i + 1))
                    {
                        item = items.Get(i + 1);
                        items.Set(i + 1, items.Get(i));
                        items.Set(i , item);
                        swapped = true;
                    }
                }
            }

            return items;
        }
    }
}