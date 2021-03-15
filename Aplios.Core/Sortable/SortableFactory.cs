using System;

namespace Aplios.Core.Sortable {

    public enum SortableType {
        BubbleSort,
        InsertSort
    }

    public class SortableFactory<T> where T : IComparable {

        public static ISortable<T> CreateInstance(SortableType sortType) {
            ISortable<T> sortable = null;

            switch (sortType) {
                case SortableType.BubbleSort:
                    sortable = new BubbleSorter<T>();
                    break;
                case SortableType.InsertSort:
                    sortable = new InsertSorter<T>();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Nieokreślony typ sortowania");
            }

            return sortable;
        }
    }
}
