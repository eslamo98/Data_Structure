using System;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Node<int> n1 = new Node<int>(1);
            //Node<int> n2 = new Node<int>(2);
            //n1.NextNode = n2;
            //Node<int> n3 = new Node<int>(3);
            //n2.NextNode = n3;
            //Console.WriteLine(n1.NextNode);

            LinkedList<int> l = new();
            Random rand = new();

            for(int i = 0; i < 5; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    l.InsertAtEnd(i);

                } else
                {
                    l.InsertAtBegining(i);
                }
            }
            
            l.InsertAtEnd(30);
            l.InsertAtBegining(30);
            l.Insert(55, 6);
            l.Clear();
            l.PrintList();
        }
    }
}
