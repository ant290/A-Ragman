using A_Ragman.Interfaces;
using Xunit;

namespace A_Ragman.Tests
{
    public class AnagramComparerTests : IWordComparerTestsBase
    {
        /// <summary>
        /// override on the base class to return the implementation of the interface which is being tested here
        /// </summary>
        /// <returns>AnagramComparer</returns>
        public override IWordComparer getComparerInstance()
        {
            return new AnagramComparer();
        }

        [Fact]
        public void Test_that_anagrams_are_true()
        {
            //arrange
            var comparer = new AnagramComparer();

            //act
            var res = comparer.CompareWords("leap", "pale");

            //assert
            Assert.True(res);
        }

        [Fact]
        public void Test_that_not_anagrams_are_false()
        {
            //arrange
            var comparer = new AnagramComparer();

            //act
            var res = comparer.CompareWords("wasp", "shop");

            //assert
            Assert.False(res);
        }
    }
}
