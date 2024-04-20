
namespace hw10
{
    internal class PriorityQueue<T>
    {
        private T[] _data;
        private int[] _priorities;
        private int _count;

        public PriorityQueue(int size)
        {
            _data = new T[size];
            _priorities = new int[size];
            _count = 0;
        }

        public void Enqueue(T item, int priority)
        {
            if (_count == _data.Length)
            {
                Console.WriteLine("Queue is full");
            }
            _data[_count] = item;
            _priorities[_count] = priority;
            _count++;
        }
        public T Dequeue()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            int minPriorityIndex = 0;
            int minPriority = _priorities[0];

            for (int i = 1; i < _count; i++)
            {
                if (_priorities[i] < minPriority)
                {
                    minPriority = _priorities[i];
                    minPriorityIndex = i;
                }
            }

            T item = _data[minPriorityIndex];

            for (int i = minPriorityIndex; i < _count - 1; i++)
            {
                _data[i] = _data[i + 1];
                _priorities[i] = _priorities[i + 1];
            }

            _count--;
            return item;
        }
        public T Peek()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            int minPriorityIndex = 0;
            int minPriority = _priorities[0];

            for (int i = 1; i < _count; i++)
            {
                if (_priorities[i] < minPriority)
                {
                    minPriority = _priorities[i];
                    minPriorityIndex = i;
                }
            }

            return _data[minPriorityIndex];
        }
        public void Show()
        {
            Console.WriteLine("Priority Queue:");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"Priority: {_priorities[i]}, Item: {_data[i]}");
            }
        }
    }
}
