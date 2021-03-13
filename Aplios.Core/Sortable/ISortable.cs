using System;

namespace Aplios.Core.Sortable {

    /// <summary>
    /// Deklaracja mechanizmu sortowania kolekcji danych
    /// </summary>
    /// <typeparam name="T">Typ parametru interfejsu</typeparam>
    public interface ISortable<T> where T : IComparable {

        /// <summary>
        /// Metoda wykonuje sortowania elementów kolekcji tablicy
        /// </summary>
        /// <param name="array">Kolekcja danych typu tablica</param>
        void Sort(T[] array);
    }
}
