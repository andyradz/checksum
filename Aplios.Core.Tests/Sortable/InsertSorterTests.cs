using Aplios.Core.Sortable;
using Xunit;

namespace Aplios.Core.Tests.Sortable {

    public class InsertSorterTests {

        [Fact(DisplayName = "Test sortowania tablicy elmentów int algorytmem sortowania przez wstawianie")]
        public void TestInsertSort_ForIntArray() {

            int[] array = { 5, 4, 0, -100, 100, 55, 0, 2, 1, -1 };
            
            var sorter = SortableFactory<int>.CreateInstance(SortableType.InsertSort);

            sorter.Sort(array);

            Assert.Collection(array,
                item => Assert.Equal(-100, item),
                item => Assert.Equal(-1, item),
                item => Assert.Equal(0, item),
                item => Assert.Equal(0, item),
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(100, item)
                );
        }

        [Fact(DisplayName = "Test sortowania tablicy elmentów double algorytmem przez wstawianie")]
        public void TestInsertSort_ForDoubleArray() {

            double[] array = { 5.09, 4.91, 0.1, -100.76, 100.87, 55, 0.2, 0.21, 1.11, -1.98, 5.091, 0 };

            var sorter = SortableFactory<double>.CreateInstance(SortableType.InsertSort);

            sorter.Sort(array);

            Assert.Collection(array,
                item => Assert.Equal(-100.76, item),
                item => Assert.Equal(-1.98, item),
                item => Assert.Equal(0, item),
                item => Assert.Equal(0.1, item),
                item => Assert.Equal(0.2, item),
                item => Assert.Equal(0.21, item),
                item => Assert.Equal(1.11, item),
                item => Assert.Equal(4.91, item),
                item => Assert.Equal(5.09, item),
                item => Assert.Equal(5.091, item),
                item => Assert.Equal(55, item),
                item => Assert.Equal(100.87, item)
                );
        }
    }
}
