using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoftProj.Core.Parsers.ParserSettings
{
    public class LinkOnlyParserSettings:IParserSettings
    {
        string baseUrl;
        public LinkOnlyParserSettings(string BaseUrl)
        {
            baseUrl = BaseUrl;
        }
        public string BaseUrl
        {
            get
            {
                return baseUrl;
            }
            set
            {
                baseUrl = value;
            }
        }
    }
}
