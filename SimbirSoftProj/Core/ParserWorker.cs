using AngleSharp.Html.Parser;
using SimbirSoftProj.Core.Log;
using System;

namespace SimbirSoftProj.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;
        public IParser<T> Parser
        {
            get
            { return parser; }
            set
            { parser = value; }
        }
        public IParserSettings ParserSettings
        {
            get
            { return parserSettings; }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public event Action<object, T> OnNewData;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }
        public ParserWorker(IParser<T> parser, IParserSettings parserSettings)
            : this(parser)
        {
            this.parserSettings = parserSettings;
            loader = new HtmlLoader(parserSettings);
        }

        public async void Worker()
        {
            var source = await loader.GetSource();
            try
            {
                var domParser = new HtmlParser();
                var document = await domParser.ParseDocumentAsync(source);
                var result = parser.Parse(document);
                Logger.WriteLog($"The page was parsed.");
                OnNewData?.Invoke(this, result);
            }
            catch(Exception ex)
            {
                Logger.WriteLog($"The page was not parsed due to an error. [{ex.Message}]");
            }
            
        }
    }
}
