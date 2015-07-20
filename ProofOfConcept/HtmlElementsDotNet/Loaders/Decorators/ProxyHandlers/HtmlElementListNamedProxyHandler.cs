﻿using ImpromptuInterface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Dynamic;
using HtmlElementsDotNet.HtmlElements.Elements;
using HtmlElementsDotNet.HtmlElements.PageFactories.Selenium;

namespace HtmlElementsDotNet.HtmlElements.Loaders.Decorators.ProxyHandlers
{
    public class HtmlElementListNamedProxyHandler : DynamicObject
    {
        private Type elementType;
        private IElementLocator locator;
        private string name;

        private HtmlElementListNamedProxyHandler(Type elementType, IElementLocator locator, string name)
            : base()
        {
            this.elementType = elementType;
            this.locator = locator;
            this.name = name;
        }

        public static IList<HtmlElement> newInstance(Type listType, Type elementType, IElementLocator locator, string name)
        {
            return new HtmlElementListNamedProxyHandler(elementType, locator, name).ActLike(listType);
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            IList<HtmlElement> elements = GetElements();

            try
            {
                result = elements.GetType().GetMethod(binder.Name).Invoke(elements, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            IList<HtmlElement> elements = GetElements();

            try
            {
                result = elements.GetType().GetProperty(binder.Name).GetValue(elements);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            int index = (int)indexes[0];
            IList<HtmlElement> elements = GetElements();
            try
            {
                result = elements[index];
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        private IList<HtmlElement> GetElements()
        {
            IList<HtmlElement> htmlElements = new List<HtmlElement>();
            IList<IWebElement> elements = locator.FindElements();
            int elementNumber = 0;
            foreach (IWebElement element in elements)
            {
                HtmlElement htmlElement = HtmlElementFactory.CreateHtmlElementInstance(elementType);
                htmlElement.WrappedElement = element;
                string htmlElementName = string.Format("{0} {1}", name, elementNumber);
                htmlElement.Name = htmlElementName;
                PageFactory.InitElements(new HtmlElementDecorator(element), htmlElement);
                htmlElements.Add(htmlElement);
                elementNumber++;
            }
            return htmlElements;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
