using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using TurboCollections;

namespace TurboBinnarySearchTree
{
    

    public class TurboBinarySearchTree
    {
        public class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Data { get; set; }

            public Node(int nodeData)
            {
                Data = nodeData;
                RightNode = null;
                LeftNode= null;
            }
        }
        

        public TurboBinarySearchTree()
        {
            headNode = null;
            Count = 0;
        }

        public int Count { get; private set; }
        private Node headNode { get; set; }

        public Node Insert(int data)
        {
            Node newNode = new Node(data);
            if (headNode== null)
            {
                headNode = newNode;
                newNode.LeftNode = newNode.RightNode = null;
                Count++;
                return headNode;
            }
            else
            {
                return InsertNewNode(newNode, data);
            }
        }
        public Node InsertNewNode(Node root, int y)
        {
            if (root == null)
            {
                root = new Node(y);
                root.LeftNode = root.RightNode = null;
                Count++;
            }
            else if (y < root.Data)
            {
                root.LeftNode = InsertNewNode(root.LeftNode, y);
            }
            else
            {
                root.RightNode = InsertNewNode(root.RightNode, y);
            }

            return root;
        }
    }
}
