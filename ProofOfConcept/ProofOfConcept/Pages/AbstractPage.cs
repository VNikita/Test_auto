using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using HtmlElements.Elements;

namespace ProofOfConcept.Pages
{
    public abstract class AbstractPage
    {
        [FindsBy(How = How.Id, Using = "PH_user-email")]
        private HtmlLink userMailText;

        public Boolean isMailTextPresent()
        {
            try
            {
                return userMailText.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
