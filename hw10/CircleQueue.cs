
namespace hw10
{
    internal class CircleQueue<T>
    {
        private T[] _data;
        private int _size;
        private int _head;
        private int _tail;
        private int _count;
        public CircleQueue(int size)
        {
            _size = size;
            _data = new T[_size];
            _head = 0;
            _tail = -1;
            _count = 0;
        }

        public void Enqueue(T item)
        {
            if (_count == _size)
            {
                Console.WriteLine("Queue is full.");
            }

            _tail = (_tail + 1) % _size;
            _data[_tail] = item;
            _count++;
        }
        public T Dequeue()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty.");
            }

            T dequeuedItem = _data[_head];
            _data[_head] = default(T);
            _head = (_head + 1) % _size;
            _count--;
            return dequeuedItem;
        }
        public T Peek()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty.");
            }

            return _data[_head];
        }

        public void Show()
        {
            int currentIndex = _head;
            Console.Write("Queue: ");
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_data[currentIndex] + " ");
                currentIndex = (currentIndex + 1) % _size;
            }
            Console.WriteLine();
        }
    }
}
