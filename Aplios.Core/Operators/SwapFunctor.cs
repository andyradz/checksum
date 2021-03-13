namespace Aplios.Core.Operators {

    public sealed class SwapFunctor<T> : ISwapFunctor<T> {
        
        public static ISwapFunctor<T> CreateInstance() {
            return new SwapFunctor<T>();
        }

        public void Swap(ref T leftInstance, ref T rightInstance) {
            var element = leftInstance;
            leftInstance = rightInstance;
            rightInstance = element;
        }
    }
}
