namespace TurboCollections
{
    public class TurboHashSet<T>
    {
        private T[] items = new T[60];
        public int Count { get; private set; }


        public bool Insert(T item)
        {
            
            var itemHash = item.GetHashCode();
            itemHash %= items.Length;
            var Index = -1;
            for (int i = 0; i < 3; i++)
            {
                if (items[itemHash].Equals(default(T)) && Index == -1)
                {
                    Index = itemHash;
                }

                if (items[itemHash].Equals(item))
                {
                    return false;
                }
                
            }

            if (Index == -1)
            {
                
                Resize();
                return Insert(item);
            }

            items[Index] = item;
            Count++;
            return true;
        }

        public bool Exists(T item)
        {
            var itemHash = item.GetHashCode();
            itemHash %= items.Length;
            for (int i = 0; i < 3; i++)
            {
                if (items[itemHash].Equals(item))
                {
                    return true;
                    
                }
                itemHash = CollisionResolution(itemHash);
            }
            
            return false;
        }

        public bool Remove(T item)
        {
            return false;
        }

        void Resize()
        {
            var oldItems = items;
            items = new T[items.Length * 2];
            
            Count = 0;
            
            foreach (var item in oldItems)
            {
                if (!item.Equals(default(T)))
                    Insert(item);
            }
            // throw new Exception("Exeption");
        }

        private int CollisionResolution(int index)
        {
            index++;
            if (index > items.Length) index -= items.Length;
            {
                return index;
            }
        }
        
    }
}