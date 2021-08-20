using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using SimbirSoftProj.Core;
using SimbirSoftProj.Core.Parsers.ParserSettings;

namespace ParserTests
{
    [TestFixture]
    class HtlmLoaderTest
    {
        [Test()]
        public void GetSourceTestWithExistingWebSite()
        {
            IParserSettings parserSettings = new LinkOnlyParserSettings("https://www.simbirsoft.com/career/");
            var htmlLoader = new HtmlLoader(parserSettings);
            var task = htmlLoader.GetSource();
            Assert.IsNotNull(task);
        }
        [Test()]
        public void GetSourceTestWithNonExistentWebSite()
        {
            IParserSettings parserSettings = new LinkOnlyParserSettings("https://www.NonExistingWebSite.test");
            var htmlLoader = new HtmlLoader(parserSettings);
            var task = htmlLoader.GetSource();
            Assert.IsNull(task.Result);
        }
    }
}
