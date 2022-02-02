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

        public Node SearchBinaryTree(int data)
        {
            return SearchBinaryTreeRecursively(headNode, data);
        }

        private Node SearchBinaryTreeRecursively(Node parentNode, int data)
        {
            if (parentNode.Data.Equals(data))
            {
                return parentNode;
            }
            else
            {
                if (data< parentNode.Data)
                {
                    return SearchBinaryTreeRecursively(parentNode.LeftNode, data);
                    
                }
                else
                {
                    return SearchBinaryTreeRecursively(parentNode.RightNode, data);
                }
            }
        }

        public void Remove(int key)
        {
            RemoveHelper(headNode, key);
        }

        private Node RemoveHelper(Node root, int key)
        {
            if (root== null )
            {
                return root;
            }

            if (key< root.Data)
            {
                root.LeftNode = RemoveHelper(root.LeftNode, key);
            }

            else if (key> root.Data)
            {
                root.RightNode = RemoveHelper(root.RightNode, key);
            }
            else
            {
                if (root.LeftNode == null && root.RightNode == null)
                {
                    root = null;
                }
                else if (root.LeftNode != null && root.RightNode!= null)
                {
                    var maxNode = FindMax(root.RightNode);
                    root.Data = maxNode.Data;
                    root.RightNode = RemoveHelper(root.RightNode, maxNode.Data);
                }
            }

            return root;
        }

        public Node FindMax(Node node)
        {
            while (node.LeftNode!= null)
            {
                node = node.LeftNode;
            }
            return node;
        }
    }
}
