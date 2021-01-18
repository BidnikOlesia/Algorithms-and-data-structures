using System;
using System.Collections;
using System.Collections.Generic;

namespace Homeworks
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    public class Queue<T>:IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;


        /// <summary>
        /// Добавление в очередь
        /// </summary>
        /// <param name="data">Data.</param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }

        /// <summary>
        /// Удаление из очереди
        /// </summary>
        /// <returns>The dequeue.</returns>
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;

            }
        }
    }
}
