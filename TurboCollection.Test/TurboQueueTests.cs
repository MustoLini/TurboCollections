using System;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboQueueTests
    {
        [Test]
        public void NewQueueIsEmpty()
        {
            var queue = new TurboQueue<int>();
            Assert.Zero(queue.Count);
        }

        [Test, TestCase(1), TestCase(5)]
        public void EnQueueTheLatesItem(int AmountToAdded)
        {
                TurboQueue<int> queue = new TurboQueue<int>();
                queue.EnQueue(1);
                queue.EnQueue(2);
                queue.EnQueue(3);
                queue.EnQueue(4);
                Assert.AreEqual(4,queue.Count);
        }
        
// returns the current amount of items contained in the stack.
        // int Count;

// adds one item to the back of the queue.
        // void Enqueue(T item);

// returns the item in the front of the queue without removing it.
        // T Peek();

// returns the item in the front of the queue and removes it at the same time.
        // T Dequeue();

// removes all items from the queue.
        // void Clear();
        
        
    }
}