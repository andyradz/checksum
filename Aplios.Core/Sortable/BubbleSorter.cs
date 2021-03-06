using Aplios.Core.Comparable;
using Aplios.Core.Operators;
using static Aplios.Core.Values.Valuable;
using System;

namespace Aplios.Core.Sortable {

    /// <summary>
    /// Klasa implementuje algorytm sortowania.
    /// Zastosowano sortowanie bąbelkowe.
    /// </summary>
    /// <typeparam name="T">Typ parametru klasy</typeparam>
    public sealed class BubbleSorter<T> : ISortable<T> where T : IComparable {

        /// <summary>
        /// <seealso cref="ISortable{T}.Sort(T[])"/>
        /// </summary>        
        public void Sort(T[] array) {

            if (IsNull(array))
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} cannot be null!");                       

            var isChanged = false;
            var swapFunctor = SwapFunctor<T>.CreateInstance();

            do {

                ResetValue<bool>(ref isChanged);

                for (long loopIdx = 1; loopIdx < array.Length; loopIdx++)

                    if (array[loopIdx - 1].CompareTo(array[loopIdx]) == (int)(CompareResult.Greater)) {
                        isChanged = true;
                        swapFunctor.Swap(ref array[loopIdx], ref array[loopIdx - 1]);
                    }

            } while (isChanged);
        }
    }
}

