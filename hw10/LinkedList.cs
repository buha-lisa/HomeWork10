
namespace hw10
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    internal class LinkedList<T>
    {
        private Node<T> _head;
        private int _count;

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = _head;
            _head = newNode;
            _count++;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node<T> current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            _count++;
        }

        public void RemoveFirst()
        {
            if (_head != null)
            {
                _head = _head.Next;
                _count--;
            }
        }

        public void RemoveLast()
        {
            if (_head == null)
                return;

            if (_head.Next == null)
            {
                _head = null;
            }
            else
            {
                Node<T> current = _head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            _count--;
        }

        public void Show()
        {
            Node<T> current = _head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
