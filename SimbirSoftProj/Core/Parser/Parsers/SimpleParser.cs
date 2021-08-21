using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using SimbirSoftProj.Core.Log;
using System;
using System.Collections.Generic;
using System.IO;

namespace SimbirSoftProj.Core.Parsers
{
    public class SimpleParser : IParser<string[]>
    {
        static List<string> forbidenTags = new List<string>();
        public string[] Parse(IHtmlDocument document)
        {
            List<string> text = new List<string>();
            var html = document.Body.ParentElement;

            using (StreamReader sr = new StreamReader("IgnoredTags.txt"))
            {
                while (!sr.EndOfStream)
                {
                    forbidenTags.Add(sr.ReadLine());
                }
            }

            List<IElement> elementsOfDocument = new List<IElement>();
            GetAllElements(html, elementsOfDocument);

            foreach (var element in elementsOfDocument)
            {
                try
                {
                    text.Add(element.TextContent);
                    Logger.WriteLog($"Text Content of Tag {element.TagName} has been listed. [ \"{element.TextContent}\" ]");
                }
                catch (Exception ex)
                {
                    Logger.WriteLog($"Text Content of Tag {element.TagName} hasn't been listed with error. [ {ex.Message} ]");
                }
            }

            return text.ToArray();
        }
        static void GetAllElements(IElement element, List<IElement> elements)
        {
            if (TagIsNotForbiden(element) & AreNotNestedList(element))
            {
                try
                {
                    elements.Add(element);
                    Logger.WriteLog($"Element {element.TagName} has been listed.");
                }
                catch (Exception ex)
                {
                    Logger.WriteLog($"Element {element.TagName} hasn't been listed with error. [ {ex.Message} ]");
                }
            }

            foreach (var child in element.Children)
            {
                GetAllElements(child, elements);
            }
        }
        static bool TagIsNotForbiden(IElement element)
        {
            var tag = element.TagName.ToUpper();
            return !forbidenTags.Contains(tag);
        }
        static bool AreNotNestedList(IElement element)
        {
            if (element.TagName.ToUpper() == "LI")
            {
                string[] listTags = { "UL", "OL", "DL" };
                foreach (string tag in listTags)
                    foreach (var child in element.Children)
                        if (child.TagName.ToUpper() == tag)
                            return false;
            }
            return true;
        }
    }
}
