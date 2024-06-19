using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
     internal class ClassNeoBux
    {
        static IWebDriver? Browser;

        public bool CheckElemetById(string _id)
        {
            
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                return (Browser.FindElement(By.Id(_id)).Displayed);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int GetCountFromElementId(string _id)
        {
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                return Convert.ToInt32(Browser.FindElement(By.Id(_id)).Text);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int GetCountFromElementClass(string _class)
        {
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                return Convert.ToInt32(Browser.FindElement(By.ClassName(_class)).Text);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void MoveToTab(int _tabNumer)
        {
            List<String> AfterTabs = Browser.WindowHandles.ToList();
            Browser.SwitchTo().Window(AfterTabs[_tabNumer]);

        }
        public void InputCapcha(string _capcha)
        {
            Browser.FindElement(By.Id("Kf3")).SendKeys(_capcha);
        }
        public Image GetCapchaPicture()
        {
            System.Drawing.Image capchaImage;

            string capchaString = Browser.FindElement(By.TagName("img")).GetDomAttribute("src").Split(',')[1];
            byte[] bytes = Convert.FromBase64String(capchaString);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            capchaImage = System.Drawing.Image.FromStream(ms);

            return capchaImage;
        }
        public bool ElementExistId(string _id)
        {
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                return (Browser.FindElement(By.Id(_id)).Displayed);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetAdvCount(string _class) 
        {
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                return Convert.ToInt32(Browser.FindElement(By.ClassName(_class)).Text);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public void ClickElementByLinkText(string _linkText)
        {
            try
            {
                if (Browser is not null)
                {
                    Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    Browser.FindElement(By.LinkText(_linkText)).Click();
                }
            }
            catch (Exception)
            {
            }
        }
        public void ClickElementById(string _id)
        {
            if (Browser is not null)
            {
                Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                Browser.FindElement(By.Id(_id)).Click();
            }
        }
        public void InputPassword(string _password)
        {
          if (Browser is not null)
            {
                for (int i = 0; i < _password.Length; i++)
                {
                    Browser.FindElement(By.Id("Kf2")).SendKeys(_password[i].ToString());
                }
            }
        }
        public void InputLogin(string _login)
        {
         if (Browser is not null) 
            {
                for (int i = 0; i < _login.Length; i++)
                {
                    Browser.FindElement(By.Id("Kf1")).SendKeys(_login[i].ToString());
                }
            }
        }
        public void GoToWebPage(string _url)
        {
            if (Browser is not null)
            {
                Browser.Url = _url;
            }
        }
        public void InitBrowser()
        {
            FirefoxOptions options = new FirefoxOptions();
            //options.AddArguments(@"user-data-dir=" + appData);
            //options.AddArgument("-headless");
            //options.AddArgument("-disable-gpu");

            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            Browser = new FirefoxDriver(driverService, options);
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }
        public void ExitProgram()
        {
            if (Browser is not null)
            {
                Browser.Close();
                Browser.Quit();
            }
        }
    }
}
