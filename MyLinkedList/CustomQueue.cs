using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class CustomQueue<T>
    {
        private int front;
        private int back;
        private int size;
        private T[] data;

        public int Count { get; private set; }

        public CustomQueue(int size)
        {
            this.size = size;
            data = new T[size];
            front = back = Count = 0;
        }

        public void Enqueue(T val)
        {
            if (Count == size)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            data[back] = val;
            back = (back + 1) % size;
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T value = data[front];
            front = (front + 1) % size;
            Count--;
            return value;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return data[front];
        }

        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write($"{data[i]}, ");
            }
        }
    }


}
