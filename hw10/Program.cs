namespace hw10
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-5): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        int x = 5; int y = 10;
                        Console.WriteLine($"X: {x} - Y: {y}");
                        new Task1().Swap(ref x, ref y);
                        Console.WriteLine($"X: {x} - Y: {y}");
                        break;
                    case 2:
                        var queue = new PriorityQueue<int>(5);
                        queue.Enqueue(1, 5);
                        queue.Enqueue(4, 1);
                        queue.Enqueue(5, 2);
                        queue.Enqueue(2, 3);
                        queue.Enqueue(7, 4);
                        queue.Show();
                        break;
                    case 3:
                        var queue2 = new CircleQueue<int>(5);
                        queue2.Enqueue(1);
                        queue2.Enqueue(4);
                        queue2.Enqueue(5);
                        queue2.Enqueue(2);
                        queue2.Enqueue(7);
                        queue2.Show();
                        break;
                    case 4:
                        var list1 = new LinkedList<int>();
                        list1.AddLast(1);
                        list1.AddLast(2);
                        list1.AddLast(3);
                        list1.AddFirst(4);
                        list1.AddFirst(7);
                        list1.Show();
                        break;
                    case 5:
                        var list2 = new DoubleLinkedList<int>();
                        list2.AddLast(1);
                        list2.AddLast(2);
                        list2.AddLast(3);
                        list2.AddFirst(4);
                        list2.AddFirst(7);
                        list2.ShowForward();
                        break;
                }

                if (task == 0) break;
            }
        }
    }
}
