using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    public class TurboListTests
    {
        [Test]
        public void NewListIsEmpty()
        {
            var list = new TurboList<int>();
            Assert.Zero(list.Count);
        }

        [Test, TestCase(4), TestCase(7)]
        public void AddingElementIncreasesCountToOne( int numberOfElements)
        {
            var list = new TurboList<int>();
            for (int i = 0; i < numberOfElements; i++)
                list.Add(5);
            Assert.AreEqual(numberOfElements, list.Count);
        }

        [Test]
        public void AnAddedElementCanBeGet()
        {
            var list = new TurboList<int>();
            list.Add(1337);
            Assert.AreEqual(1337, list.Get(0));
        }


        [Test]
        public void ClearIndexElement()
        {
            var list = new TurboList<int>();
            list.Add(1337);
            list.Add(1337);
            list.Add(1337);
            list.Clear();
            Assert.AreEqual(0,list.Count);
        }

        [Test]
        public void RemoveSpefiedIndexElement()
        {
            var list = new TurboList<int>();
            list.Add(2);
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(0);
            list.ClearSpecifed(3);
        }
        [Test]
        public void ContainsReturnsTrueIfItemPresent()
        {
            var list = new TurboList<int>();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Assert.True(list.Contains(4));
        }
        
        [Test]
        public void ContainsReturnsFalseIfItemNotPresent()
        {
            var list = new TurboList<int>();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Assert.False(list.Contains(42));
        }
        
    }
}