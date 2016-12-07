namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            var len = this.items.Count;
            for (int i = 0; i < len; i++)
            {
                if (this.items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int from = 0;
            int to = this.items.Count - 1;
            var list = new List<T>(this.Items);
            list.Sort();

            while (from <= to)
            {
                int midle = (from + to) / 2;

                if (list[midle].CompareTo(item) < 0)
                {
                    from = midle + 1;
                }
                else if (list[midle].CompareTo(item) > 0)
                {
                    to = midle - 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            var list = this.items;
            Random random = new Random();
            int n = list.Count;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(random.NextDouble() * (n - i));
                T t = list[r];
                list[r] = list[i];
                list[i] = t;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
