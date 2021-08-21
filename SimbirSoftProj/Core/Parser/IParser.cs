using AngleSharp.Html.Dom;

namespace SimbirSoftProj.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument documet);
    }
}
