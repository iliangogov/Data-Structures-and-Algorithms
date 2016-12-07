namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var collectionCount = collection.Count;
            for (int i = 0; i < collectionCount - 1; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < collectionCount; j++)
                {
                    var compare = collection[j].CompareTo(collection[minIndex]);
                    if (compare < 0)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    var temp = collection[i];
                    collection[i] = collection[minIndex];
                    collection[minIndex] = temp;
                }
            }
        }
    }
}
