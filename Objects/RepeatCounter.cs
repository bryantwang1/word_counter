using System;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _primeWord;
        private string _testString;

        public RepeatCounter(string primeWord)
        {
            _primeWord = primeWord;
            _testString = primeWord;
        }

        public RepeatCounter(string primeWord, string testString)
        {
            _primeWord = primeWord;
            _testString = testString;
        }

        public int CountRepeats()
        {
            if(_testString.Contains(_primeWord))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
