using System;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack

            #region IOnsert and remove and print and search operations in stack
            //Node<int> n1 = new Node<int>(1);
            //Node<int> n2 = new Node<int>(2);
            //n1.NextNode = n2;
            //Node<int> n3 = new Node<int>(3);
            //n2.NextNode = n3;
            //Console.WriteLine(n1.NextNode);

            //LinkedList<int> l = new();
            //Random rand = new();

            //for(int i = 0; i < 5; i++)
            //{
            //    if (rand.Next(0, 2) == 0)
            //    {
            //        l.InsertAtEnd(i);

            //    } else
            //    {
            //        l.InsertAtBegining(i);
            //    }
            //}

            //l.InsertAtEnd(30);
            //l.InsertAtBegining(30);
            //l.Insert(55, 6);
            //l.Clear();
            //l.PrintList();

            //Stack<int> s = new Stack<int>(5);
            //Console.WriteLine(s.IsEmpty());
            //s.Push(6);
            //s.Push(4);
            //s.Push(3);
            //s.Push(2);
            //s.Push(1);
            //var t = s.Pop();
            //Console.WriteLine(s.IsEmpty());
            //Console.WriteLine(t);
            //s.Print();
            #endregion


            #region Reverse String Using Stack

            //string str = "eslamo";
            //string reversedString = ReverseStringUsingStack(str);

            //Console.WriteLine(StackProblems.reversedString);
            #endregion

            #region Balanced Brackets with stack
            //Console.WriteLine(StackProblems.BalancedBrackets("{[]()}"));
            #endregion

            #region Infix to Postfix using stack
            /*
             * Test Case 1:

            Input: "A + B"
            Expected Output: "A B +"
            Test Case 2:

            Input: "A + B * C"
            Expected Output: "A B C * +"
            Test Case 3:

            Input: "(A + B) * C"
            Expected Output: "A B + C *"
            Test Case 4:

            Input: "A * B + C / D"
            Expected Output: "A B * C D / +"
            Test Case 5:

            Input: "A + B * C - D / E"
            Expected Output: "A B C * + D E / -"
            Test Case 6:

            Input: "A * (B + C) / D"
            Expected Output: "A B C + * D /"
            Test Case 7:

            Input: "A + (B - C) * (D + E)"
            Expected Output: "A B C - D E + * +"
            Test Case 8:

            Input: "(A + B) * (C + D)"
            Expected Output: "A B + C D + *"
            Test Case 9:

            Input: "(A + B * C) / (D - E)"
            Expected Output: "A B C * + D E - /"
            Test Case 10:

            Input: "A * (B + C * D) - E"
            Expected Output: "A B C D * + * E -"

            Input: "A + B * (C ^ D - E) ^ (F + G * H) - I"
            Expected Output: "A B C D ^ E - * F G H * + ^ + I -"
             */
            //Console.WriteLine(StackProblems.InFixToPostFix("A + B * (C ^ D - E) ^ (F + G * H) - I"));
            #endregion

            #region Calculate RPN
            //Console.WriteLine(StackProblems.CalculateRPN("5 6 2 3 + ^ *"));
            #endregion
            #endregion

            #region Queue
            //CustomQueue<int> q = new CustomQueue<int>(5);

            //q.Enqueue(4);
            //q.Enqueue(3);
            //q.Enqueue(2);
            //q.Enqueue(1);
            //q.Enqueue(5);
            //q.Print();
            #endregion

            #region BTree
            CustomBTree tree = new CustomBTree();
            Console.WriteLine(tree.Contains(90));
            tree.Add(90);
            tree.Add(50);
            tree.Add(40);
            tree.Add(100);
            tree.Add(140);
            tree.PrintPreOrder();
            Console.WriteLine();
            tree.PrintPostOrder();
            Console.WriteLine();
            tree.PrintInOrder();
            Console.WriteLine();
            Console.WriteLine(tree.Contains(90));
            Console.WriteLine(tree.Contains(140));
            Console.WriteLine(tree.Contains(40));
            Console.WriteLine(tree.Contains(0));
            Console.WriteLine(tree.Contains(200));
            #endregion
        }



    }
}
