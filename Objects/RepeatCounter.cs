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
            int counter = 0;
            String[] splitString = _testString.Split(' ');
            foreach(string word in splitString)
            {
                if(word == _primeWord)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
