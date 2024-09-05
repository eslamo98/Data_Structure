using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class BNode
    {
        public int value { get; set; }
        public BNode Left { get; set; }
        public BNode Right { get; set; }
        public int Count { get; private set; }

    }
    class CustomBTree
    {
        public BNode Root { get; set; }

        public void Add(int val)
        {
            if (Root == null)
            {
                Root = new BNode() { value = val };
            }
            else
            {
                AddTo(Root, val);
            }
        }

        void AddTo(BNode node, int val)
        {
            
                if (val > node.value)
                {
                    if (node.Right == null)
                    {
                        node.Right = new BNode() { value = val };
                    }
                    else
                    {
                        AddTo(node.Right, val);
                    }
                }
                else
                {
                    if (node.Left == null)
                    {
                        node.Left = new BNode() { value = val };
                    }
                    else
                    {
                        AddTo(node.Left, val);
                    }
                }
            
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(Root);
        }

         void PrintPreOrder(BNode node)
        {
            if (node  != null)
            {
            Console.Write($"{node.value}, ");
            PrintPreOrder(node.Left);
            PrintPreOrder(node.Right);
            }
        }

        public void PrintPostOrder()
        {
            PrintPostOrder(Root);
        }

        void PrintPostOrder(BNode node)
        {
            if (node != null)
            {
                PrintPostOrder(node.Left);
                PrintPostOrder(node.Right);
                Console.Write($"{node.value}, ");
            }
        }

        public void PrintInOrder()
        {
            PrintInOrder(Root);
        }

        void PrintInOrder(BNode node)
        {
            if (node != null)
            {
                PrintInOrder(node.Left);
                Console.Write($"{node.value}, ");
                PrintInOrder(node.Right);
            }
        }

        public bool Contains(int val)
        {
            
            BNode cur = Root; 
            while(cur != null)
            {
                if (val < cur.value)
                {
                    cur = cur.Left;
                }
                else if (val > cur.value)
                {
                    cur = cur.Right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

    }
}
