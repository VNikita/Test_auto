using System.Reflection;

namespace HtmlElementsDotNet.HtmlElements.PageFactories.Selenium
{
    public interface IElementLocatorFactory
    {
        IElementLocator CreateLocator(FieldInfo field);
    }
}
