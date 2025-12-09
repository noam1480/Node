using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    public class Node<T>
    {
        private T value;
        private Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.Next = next;
        }
        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.Next;
        }
        public bool HasNext()
        {
            return this.Next != null;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetNext(Node<T> next)
        {
            this.Next = next;
        }
        public override string ToString()
        {

            return value.ToString();
        }
    }
}
