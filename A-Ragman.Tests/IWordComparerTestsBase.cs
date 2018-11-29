using A_Ragman.Interfaces;
using Xunit;
using System;

namespace A_Ragman.Tests
{
    public abstract class IWordComparerTestsBase
    {
        //spoke about abstract classes and i didn't have an example, here I am using it so that I can inherit this test case into all my test cases that implement the IWordComparer interface
        public abstract IWordComparer getComparerInstance();

        [Fact]
        public void Test_will_throw_argumentNullException()
        {
            //arrange
            //var comparer = new AnagramComparer();
            var comparer = getComparerInstance();
            
            //act
            //nothing to do

            //assert
            Assert.Throws<ArgumentNullException>(() => comparer.CompareWords("boo", null));
        }
    }
}
