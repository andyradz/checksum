namespace Aplios.Core.Operators {

    /// <summary>
    /// Deklaracja mechanizmu zamiany referencji między instancjami obiektów tego samego typu
    /// </summary>
    /// <typeparam name="T">Parametr interfejsu</typeparam>
    public interface ISwapFunctor<T> {
        void Swap(ref T elementLeft, ref T elementRight);
    }
}
