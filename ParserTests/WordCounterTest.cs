using NUnit.Framework;
using System;
using System.Collections.Generic;
using SimbirSoftProj.Core;
using SimbirSoftProj.Core.Parsers;

namespace ParserTests
{
    [TestFixture]
    public class WordCounterTest
    {
        [Test()]
        public void GetCountedWordsTest()
        {
            string[] input = { "Я просто тестовая строка", "Я!просто\"тестовая\"строка!","123" };
            Dictionary<string, int> actual = WordCounter.GetCountedWords(input);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "Я", 2 },
                { "ПРОСТО", 2 },
                { "ТЕСТОВАЯ", 2 },
                { "СТРОКА", 2 },
                { "123", 1 }
            };
            CollectionAssert.AreEqual(expected,actual);
        }
    }
}
