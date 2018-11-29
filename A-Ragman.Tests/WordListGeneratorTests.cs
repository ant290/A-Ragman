using A_Ragman.Helpers;
using System.Collections.Generic;
using Xunit;

namespace A_Ragman.Tests
{
    public class WordListGeneratorTests
    {
        [Fact]
        public void Test_that_list_is_generated()
        {
            //arrange
            var wordsGenerator = new WordListGenerator();

            //act
            //nothing to do

            //assert
            Assert.Equal(1, 1);
            Assert.IsType<List<WordListModel>>(wordsGenerator.GetWords());
        }
    }
}
