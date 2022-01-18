using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboStackTest
    {

        [Test]
        public void NewStackIsEmpty()
        {
            TurboStack<int> Stack= new TurboStack<int>();
            Assert.Zero(Stack.Count);
        }

        [Test, TestCase(1),TestCase(5)]
        public void ReturnCorrectValue(int AmountToAdded)
        {
            TurboStack<int> stack= new TurboStack<int>();
            for (int i = 0; i < AmountToAdded; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(AmountToAdded, stack.Count);
        }

        
    }
}