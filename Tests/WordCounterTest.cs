using Xunit;
using WordCounter.Objects;

namespace WordCounterTest
{
    public class CountWordAppearancesInInput
    {
        [Fact]
        public void StringContainsItself_InputThis_Return1()
        {
            string firstWord = "This";
            RepeatCounter newCounter = new RepeatCounter(firstWord);
            int result = newCounter.CountRepeats();
            Assert.Equal(1, result);
        }
        [Theory]
        [InlineData("This","This",1)]
        [InlineData("This","This is a simple sentence is this not",2)]
        [InlineData("This","this is a simple sentence is this not",2)]
        [InlineData("This","\"This, is a simple sentence is this not!?\"",2)]
        [InlineData("This","\"This is a simple sentence is this not?\"",2)]
        public void CountWordRepeatingInSentence_InputWordThisAndASentence_ReturnAppearancesOfThis(string primeWord, string testSentence, int expectedResult)
        {
            RepeatCounter newCounter = new RepeatCounter(primeWord, testSentence);
            int result = newCounter.CountRepeats();
            Assert.Equal(expectedResult, result);
        }
    }
}
