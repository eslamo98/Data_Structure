using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Node<T>
    {
        public T data { get; set; }
        public Node<T> NextNode { get; set; }

        public Node(T  value)
        {
            this.data = value;
            this.NextNode = null;
        }
    }

    class LinkedList<T>
    {
        int _count = 0;
        public int Count { get => _count; }
         Node<T> Head { get; set; }
         Node<T> Tail { get; set; }
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void InsertAtEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if(Head == null)
            {
                Head = Tail = newNode;
               
            } else
            {
                Tail.NextNode = newNode;
                Tail = newNode;
            }
                this._count += 1;
        }

        public void InsertAtBegining(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.NextNode = Head;
                Head = newNode;
            }
                this._count += 1;
        }

        public bool Search(T val)
        {
            Node<T> cur = Head;
            if(cur == null)
            {
                return false;
            }
            while(cur != null)
            {
                if(cur.data.Equals(val))
                {
                    return true;
                }
                cur = cur.NextNode;
            }

            return false;

        }

        //public bool Remove(T val)
        //{
        //    Node<T> cur = Head;
        //    Node<T> prev = null;
        //    if (cur == null)
        //    {
        //        return false;
        //    }
        //    while (cur != null)
        //    {

        //        if (cur.data.Equals(val))
        //        {
        //            if(cur == Head)
        //            {
        //                Head = cur.NextNode;
        //                cur.NextNode = null;
        //            } else if(cur == Tail)
        //            {
        //                cur.NextNode = null;
        //                Tail = prev;
        //                Tail.NextNode = null;
        //            } else
        //            {
        //                prev.NextNode = cur.NextNode;
        //                cur.NextNode = null;
        //            }
        //            return true;
        //        }
        //        prev = cur;
        //        cur = cur.NextNode;

        //    }

        //    return false;
        //}

        public bool Remove(T val)
        {
            
            if (Head == null)
            {
                return false;
            }
            if(Head.data.Equals(val))
            {

                Head = Head.NextNode;
                this._count -= 1;
                return true;

            }
            var prev = Head;
            var cur = Head.NextNode;
            while (cur != null)
            {

                if (cur.data.Equals(val))
                {
                    
                     if (cur == Tail)
                    {
                        cur.NextNode = null;
                        Tail = prev;
                        Tail.NextNode = null;

                    }
                    else
                    {
                        prev.NextNode = cur.NextNode;
                        cur.NextNode = null;
                    }
                    this._count -= 1;
                    return true;
                }
                prev = cur;
                cur = cur.NextNode;

            }

            return false;
        }

        //public void Insert(T val, int pos)
        //{
        //    if (pos < 0  || pos > _count) throw new ArgumentOutOfRangeException();
        //    var newNode = new Node<T>(val);

        //    if (Head == null) {
        //        Head = Tail = newNode;
        //        this._count += 1;

        //    };
        //    int position = 0;
        //    if (position == pos)
        //    {

        //        newNode.NextNode = Head;
        //        Head = newNode;
        //        this._count += 1;
        //        return;

        //    }
        //    position++;
        //    var cur = Head.NextNode;
        //    var prev = Head;
        //    while(cur != null)
        //    {
        //        if(position == pos)
        //        {
        //             if(cur == Tail)
        //            {
        //                newNode.NextNode = Tail;
        //                prev.NextNode = newNode;

        //            }
        //            else
        //            {
        //                prev.NextNode = newNode;
        //                newNode.NextNode = cur;
        //            }
        //            this._count += 1;
        //            return;

        //        }
        //        position++;
        //        prev = cur;
        //        cur = cur.NextNode;
        //    }


        //}

        public void Insert(T val, int pos)
        {
            if (pos < 0 || pos > _count)
                throw new ArgumentOutOfRangeException();

            var newNode = new Node<T>(val);

            if (pos == 0)  // Insert at the beginning
            {
                newNode.NextNode = Head;
                Head = newNode;
                if (Tail == null)  // If list was empty
                {
                    Tail = newNode;
                }
                _count++;
                return;
            }

            // Traverse the list to find the position
            int position = 1;
            var cur = Head.NextNode;
            var prev = Head;

            while (cur != null && position < pos)
            {
                prev = cur;
                cur = cur.NextNode;
                position++;
            }

            // Insert at the specified position
            prev.NextNode = newNode;
            newNode.NextNode = cur;

            if (cur == null)  // If inserted at the end
            {
                Tail = newNode;
            }

            _count++;
        }


        public void Clear()
        {
            Head = Tail = null;
            _count = 0;
        }
        public void PrintList()
        {
            Node<T> cur = Head;
            if (cur == null)
            {
                Console.WriteLine("The list is empty ...");
            }
            else
            {
                Console.Write("{ ");
                while (cur != null)
                {
                    Console.Write($"{cur.data}");
                    cur = cur.NextNode;
                    if (cur != null)
                    {
                        Console.Write(", ");
                    }
                }

                Console.Write(" }");
                Console.WriteLine($" Count: {Count}");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> cur = Head;
            while (cur != null)
            {
                sb.Append($"{cur.data} -> ");
                cur = cur.NextNode;
            }
            sb.Append("null");
            return sb.ToString();
        }

    }
}
