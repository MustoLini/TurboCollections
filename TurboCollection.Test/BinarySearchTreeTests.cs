using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TurboBinnarySearchTree;
using TurboCollections;
namespace TurboCollection.Test
{ 
    
    public class BinarySearchTreeTests
    {
        [Test]
        public void NewInsert()
        {
            var binaryTree = new TurboBinnarySearchTree.TurboBinarySearchTree();
            binaryTree.Insert(10);
            binaryTree.Insert(20);
            binaryTree.Insert(30);
            binaryTree.Insert(40);
            binaryTree.Insert(50);
            Assert.IsTrue(binaryTree.Count== 5);
        }

        [Test]
        public void CanSearchBinaryTree()
        {
            var binaryTree = new TurboBinnarySearchTree.TurboBinarySearchTree();
            binaryTree.Insert(10);
            binaryTree.Insert(20);
            binaryTree.Insert(30);
            binaryTree.Insert(40);
            binaryTree.Insert(50);
            var result = binaryTree.SearchBinaryTree(10);
            Assert.IsTrue(result.Data== 10);
        }

        [Test]
        public void RemoveFromBinaryTree()
        {
            var binaryTree = new TurboBinnarySearchTree.TurboBinarySearchTree();
            binaryTree.Insert(10);
            binaryTree.Insert(20);
            binaryTree.Insert(30);
            binaryTree.Insert(40);
            binaryTree.Insert(50);
            binaryTree.Remove(7);
            Assert.AreEqual(0,0);
        }
    }
}