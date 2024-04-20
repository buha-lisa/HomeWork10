
namespace hw10
{
    public class NodeToDouble<T>
    {
        public T Data { get; set; }
        public NodeToDouble<T> Next { get; set; }
        public NodeToDouble<T> Previous { get; set; }

        public NodeToDouble(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
    internal class DoubleLinkedList<T>
    {
        private NodeToDouble<T> _head;
        private NodeToDouble<T> _tail;
        private int _count;

        public int Count => _count;

        public DoubleLinkedList()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public void AddFirst(T data)
        {
            NodeToDouble<T> newNode = new NodeToDouble<T>(data);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }
            _count++;
        }

        public void AddLast(T data)
        {
            NodeToDouble<T> newNode = new NodeToDouble<T>(data);
            if (_tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Previous = _tail;
                _tail.Next = newNode;
                _tail = newNode;
            }
            _count++;
        }

        public void RemoveFirst()
        {
            if (_head == null)
                return;

            if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Previous = null;
            }
            _count--;
        }

        public void RemoveLast()
        {
            if (_tail == null)
                return;

            if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _tail = _tail.Previous;
                _tail.Next = null;
            }
            _count--;
        }

        public void ShowForward()
        {
            NodeToDouble<T> current = _head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void ShowBackward()
        {
            NodeToDouble<T> current = _tail;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Previous;
            }
            Console.WriteLine();
        }
    }
}
