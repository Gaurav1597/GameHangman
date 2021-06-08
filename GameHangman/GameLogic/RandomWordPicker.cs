using System;
using System.Collections.Generic;

namespace GameHangman
{
    //Pass in a list of words to initialize.
    public class RandomWordPicker
    {
        private List<string> Wordlist { get; set; }

        public RandomWordPicker(List<string> list)
        {
            Wordlist = list;
        }

        //Call this method to get a random word from the list.
        public string GetRandomWord()
        {
            int rIndex = new Random().Next(Wordlist.Count);
            string Word = Wordlist[rIndex];

            return Word;
        }
    }
}
