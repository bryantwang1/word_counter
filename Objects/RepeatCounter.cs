using System;
using System.Linq;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _primeWord;
        private string _testString;
        private int _counter = 0;
        private string[] _nonLetterChars = { "!", "@", "#", "$", "%", "^", "&", "*", "+", "=", "\"", ":", ";", ".", ",", "?", "~", "`", "(", ")", "\\", "/", "|", "'" };

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

        public string GetPrime()
        {
            return _primeWord;
        }

        public string GetTest()
        {
            return _testString;
        }

        public int GetCount()
        {
            return _counter;
        }

        public int CountRepeats()
        {
            string[] primeArrays = _primeWord.ToCharArray().Select( c => c.ToString()).ToArray();
            for(int idx = 0; idx < primeArrays.Length; idx++)
            {
                string character = primeArrays[idx];
                if(Array.IndexOf(_nonLetterChars, character) > -1)
                {
                    primeArrays[idx] = "";
                }
            }
            string cleanPrime = String.Join("", primeArrays);

            string[] characterArrays = _testString.ToCharArray().Select( c => c.ToString()).ToArray();
            for(int idx = 0; idx < characterArrays.Length; idx++)
            {
                string character = characterArrays[idx];
                if(character == "'")
                {
                    characterArrays[idx] = "";
                }
                else if(Array.IndexOf(_nonLetterChars, character) > -1)
                {
                    characterArrays[idx] = " ";
                }
            }
            string cleanString = String.Join("", characterArrays);

            _counter = 0;
            string[] splitString = cleanString.Split(' ');
            foreach(string word in splitString)
            {
                if(word.Equals(cleanPrime, StringComparison.OrdinalIgnoreCase))
                {
                    _counter++;
                }
            }
            return _counter;
        }
    }
}
