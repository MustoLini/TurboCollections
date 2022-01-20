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
        [Test]
        public void PeekReturnTheItemInFront()
        {
            TurboQueue<int> queue = new TurboQueue<int>();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            Assert.AreEqual(1,queue.Peek());
        }
        [Test]
        public void DequeueRemovesTheItemInFront()
        {
            TurboQueue<int> queue = new TurboQueue<int>();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            Assert.AreEqual(1, queue.Dequeue());
            queue.Dequeue();
            Assert.AreEqual(3, queue.Dequeue());
        }

        [Test]
        public void ClearReturnItem()
        {
            TurboQueue<int> queue = new TurboQueue<int>();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            Assert.AreEqual(1, queue.Dequeue());
            queue.Dequeue();
            Assert.AreEqual(3, queue.Dequeue());
            queue.Clear();
            Assert.AreEqual(0, queue.Count);
        }


        
        
    }
}