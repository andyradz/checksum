using Aplios.Core.Values;
using Xunit;

namespace Aplios.Core.Tests {

    public class DefaultTests {

        [Fact(DisplayName = "Test domy�lnej warto�ci dla typu Boolean")]
        public void TestBoolean_DefaultValue() {

            bool defaultValue = Default.ZeroOf<bool>();

            Assert.False(defaultValue);
        }

        [Fact(DisplayName = "Test domy�lnej warto�ci dla typu String")]
        public void TestString_DefaultValue() {

            string defaultValue = Default.ZeroOf<string>();

            Assert.Empty(defaultValue);
        }
    }
}
