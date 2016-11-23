namespace QueueImplementation
{
    using System.Collections.Generic;

    public class LinkedQueue<T>
    {
        private LinkedList<T> list;

        public LinkedQueue()
        {
            this.list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.list.AddFirst(item);
        }

        public T Dequeue()
        {
            var item = this.list.Last;
            this.list.RemoveLast();
            return item.Value;
        }

        public int Count()
        {
            return this.list.Count;
        }
    }
}
