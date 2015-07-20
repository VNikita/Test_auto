using System;
using System.Reflection;
using HtmlElementsDotNet.HtmlElements.PageFactories.Selenium;

namespace HtmlElementsDotNet.HtmlElements.PageFactories
{
    // Done
    public abstract class CustomElementLocatorFactory : IElementLocatorFactory
    {
        public virtual IElementLocator CreateLocator(FieldInfo field)
        {
            return null;
        }

        public virtual IElementLocator CreateLocator(Type clazz)
        {
            return null;
        }
    }
}
