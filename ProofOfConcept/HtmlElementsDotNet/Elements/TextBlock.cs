using OpenQA.Selenium;

namespace HtmlElementsDotNet.HtmlElements.Elements
{
    public class TextBlock : TypifiedElement
    {
        public TextBlock(IWebElement element)
            : base(element)
        { }

        public string Text
        {
            get { return WrappedElement.Text; }
        }
    }
}
