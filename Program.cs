using System;
using System.Collections.Generic;

namespace listofDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

             dictionaryOfWords.Add(excitedWord);

            excitedWord.Add("word", "excited");
             excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
              excitedWord.Add( "part of speech", "adjective");
               excitedWord.Add("example sentence", "I am excited to learn C#!");
            
            
            Dictionary<string, string> cooledWord = new Dictionary<string, string>();

            dictionaryOfWords.Add(cooledWord);
        
             cooledWord.Add("word", "cooled");
             cooledWord.Add("definition", "having, cool, or characterized by a heightened state of energy, enthusiasm, eagerness");
              cooledWord.Add( "part of speech", "noun");
               cooledWord.Add("example sentence", "I am look cooled to learn C#!");

            foreach (Dictionary<string, string>
            dictionaries in dictionaryOfWords)
            {
                foreach (KeyValuePair<string, string> wordData in dictionaries)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");



                }
            }
        }
    }
}

