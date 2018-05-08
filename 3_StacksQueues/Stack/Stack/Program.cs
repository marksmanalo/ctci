using System;

// Stack implementation using a linked list
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<int>();
            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(2);
            myStack.Push(1);

            var topStack = myStack.Peek();
            Console.WriteLine("Top Stack: " + topStack);

            var isStackEmpty = myStack.IsEmpty();
            Console.WriteLine("Stack.IsEmpty() = " + isStackEmpty);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine("Stack.IsEmpty() = " + myStack.IsEmpty());
        }
    }

    public class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T> next { get;set;}

        public StackNode(T data)
        {
            Data = data;
        }
    }

    public interface IStack<T> 
    {
        void Push(T data);
        T Pop();
        T Peek();
        bool IsEmpty();
    }

    public class Stack<T> : IStack<T>
    {
        private StackNode<T> _top = null;
        
        public void Push(T data)
        {
            var newNode = new StackNode<T>(data);
            newNode.next = _top;
            _top = newNode;
        }

        public T Pop()
        {
            if (_top == null) throw new Exception("Empty stack!");

            var topNodeData = _top.Data;
            _top = _top.next;
            return topNodeData;
        }

        public T Peek()
        {
            if (_top == null) throw new Exception("Empty stack!");

            return _top.Data;
        }

        public bool IsEmpty()
        {
            return _top == null;
        }
    }
}
