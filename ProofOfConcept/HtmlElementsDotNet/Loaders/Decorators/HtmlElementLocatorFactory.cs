using OpenQA.Selenium;
using System;
using System.Reflection;
using HtmlElementsDotNet.HtmlElements.PageFactories;
using HtmlElementsDotNet.HtmlElements.PageFactories.Selenium;

namespace HtmlElementsDotNet.HtmlElements.Loaders.Decorators
{
    // Done
    public class HtmlElementLocatorFactory : CustomElementLocatorFactory
    {
        private ISearchContext searchContext;

        public HtmlElementLocatorFactory(ISearchContext searchContext)
        {
            this.searchContext = searchContext;
        }

        public override IElementLocator CreateLocator(FieldInfo field)
        {
            return new AjaxElementLocator(searchContext, new HtmlElementFieldAttribytesHandler(field));
        }

        public override IElementLocator CreateLocator(Type type)
        {
            return new AjaxElementLocator(searchContext, new HtmlElementTypeAttributesHandler(type));
        }
    }
}
