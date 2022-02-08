using System.Collections.Generic;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboHashSetTest
    {
        TurboHashSet<int> HashSet()
        {
            TurboHashSet<int> hashSet = new TurboHashSet<int>();
            int[] numbers = Number();
            foreach (var VARIABLE in numbers)
            {
                hashSet.Insert(VARIABLE);
            }
            return hashSet;
        }
        int[] Number()
        {
            return new[] {9, 98, 658, 72, 82, 83, 7000, 9000};
        }

        [Test, TestCase(1), TestCase(5)]
        public void Insert(int itemsAdded)
        {
            TurboHashSet<int> hashSet = new TurboHashSet<int>();
            for (int i = 0; i < itemsAdded+1; i++)
            {
                hashSet.Insert(i * i);
            }
            Assert.AreEqual(itemsAdded,hashSet.Count);
        }
        [Test]

        public void ExistReturnItemPresent()
        {
            var hashSet = HashSet();
            var numbers = Number();
            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(false,hashSet.Exists(numbers[i]* 2));
            }
        }
    }
}