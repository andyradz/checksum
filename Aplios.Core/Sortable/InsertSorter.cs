using Aplios.Core.Comparable;
using System;
using static Aplios.Core.Values.Valuable;

namespace Aplios.Core.Sortable {

    /// <summary>
    /// Klasa implementuje algorytm sortowania.
    /// Zastosowano sortowanie przez wstawianie.
    /// </summary>
    /// <typeparam name="T">Typ parametru klasy</typeparam>
    public sealed class InsertSorter<T> : ISortable<T> where T : IComparable {

        /// <summary>
        /// <seealso cref="ISortable{T}.Sort(T[])"/>
        /// </summary>        
        public void Sort(T[] array) {

            if (IsNull(array))
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} cannot be null!");

            for (long idx = 1, jdx = idx - 1; idx < array.Length; ++idx, jdx = idx - 1) {

                T value = array[idx];

                for (; (jdx >= 0 && array[jdx].CompareTo(value) == (int)CompareResult.Greater); --jdx)
                    array[jdx + 1] = array[jdx];                

                array[jdx + 1] = value;
            }
        }
    }
}

