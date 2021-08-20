using System.Collections.Generic;
using System.Collections;
using System.Linq;
using SimbirSoftProj.Core.Log;
using System;

namespace SimbirSoftProj.Core
{
    public class WordCounter
    {
        public static Dictionary<string, int> GetCountedWords(string[] text)
        {
            var words = SeparateWords(text);
            var countedWordsList = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var upstringWord = words[i].ToUpper();
                try
                {
                    if (countedWordsList.Keys.Contains(upstringWord))
                        countedWordsList[upstringWord]++; 
                    else
                        countedWordsList.Add(upstringWord, 1);
                    
                }
                catch(Exception ex)
                {
                    Logger.WriteLog($"The word could not be counted due to an error. [ {ex.Message} ]");
                }
                
                
            }
            return countedWordsList;
        }
        static string[] SeparateWords(string[] text)
        {
            var words = new List<string>();
            var separators = new char[] { ' ', ',', '.','\'', '!', '?', '"', ';', ':', '[', ']', '(', ')', '«', '»', '—', '\n', '\r', '\t' };
            foreach (var sentence in text)
            {
                try
                {
                    var splitedSentence = sentence.Split(separators);
                    var clearedSentence = DeleteWhiteSpase(splitedSentence);
                    Logger.WriteLog($"The sentence was divided into words. {String.Join(",",clearedSentence)}");
                    foreach (var word in clearedSentence)
                    {
                        words.Add(word);
                    }
                }
                catch(Exception ex)
                {
                    Logger.WriteLog($"The sentence wasn't divided into words. [ {ex.Message} ]");
                }
            }
            return words.ToArray();
        }
        
        static string [] DeleteWhiteSpase(string[] text)
        {
            return text.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        }
    }
}
