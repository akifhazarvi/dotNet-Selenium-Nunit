using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Daft_web_automation.HelperMethod;
using Daft_web_automation.PageObject;
using static Daft_web_automation.Common_Objects;

namespace Daft_web_automation.HelperMethod
{
    class Common_Helper
    {
        Searchparem sp = new Searchparem();
        Page_Object pg = new Page_Object();
      
      
        //function to check if element is displayed in dom
        public bool isDisplayedElem(IWebDriver dr, string elem, int time)
        {
            bool status = false;
            //loop will check that specific element X number of times
            for (int i = 1; i < time; i++)
            {
                try
                {
                    if ((dr.FindElement(By.XPath(elem)).Displayed))
                    {
                        status = true;
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Isdisplayed - {0}", i);
                    }
                }
                catch
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Isdisplayed exc- {0}", i);
                }
            }
            return status;
        }

        //Fucntion which will take screenshot
        public void take_screenshot(IWebDriver driver, string sh_filePath)
        {
            Object lockScrnshot = new Object();
            try
            {
                lock (lockScrnshot) { ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(sh_filePath, System.Drawing.Imaging.ImageFormat.Png); }
            }
            catch (Exception ex)
            {
                // try again
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    lock (lockScrnshot) { ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(sh_filePath, System.Drawing.Imaging.ImageFormat.Png); }
                }
                catch
                {
                    Console.WriteLine("INSIDE CATCH: Could not take screenshot!..thread id {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine(ex);
                }
            }
        }

        //Function to click on specific xpath
        public void clickOn(IWebDriver Driver, String ElemXpath)
        {
            //checking element is displauyed
            if (isDisplayedElem(Driver, ElemXpath, 7))
            {
                IWebElement tmpElement = Driver.FindElement(By.XPath(ElemXpath));

             //Trigering the click event
                tmpElement.Click();

            }
            else
            {
                Console.WriteLine("Unable to see Element");

            }
        }

        //Passing the complete div to get all the values and choose the specific element depending upon the value passed.
        public string get_xpath_area(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.choose_area_dropdown)).Count;
            string temp = "";
          
            for (int i = 1; i <= count; i++)
            {
                String check = driver.FindElementByXPath(pg.choose_area_dropdown + "[" + i + "]/span[2]").Text;
           
                if (check.CompareTo(sp.City_area) == 0)
                {
                    temp = pg.choose_area_dropdown + "[" + i + "]/span[2]";
                }

            }


            return temp;
        }
        public string get_xpath_country(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.Category_dropwown_elem)).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                if (driver.FindElementByXPath(pg.Category_dropwown_elem+"[" + i + "]").Text.CompareTo(sp.City_country) == 0)
                {
                    temp = pg.Category_dropwown_elem + "[" + i + "]";
                }

            }
            

            return temp;
        }
        public string get_xpath_minprice(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.min_price_dropdown_elem)).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                if (driver.FindElementByXPath(pg.min_price_dropdown_elem + "[" + i + "]").Text.ToString().Replace("€", "").CompareTo(sp.MinPriceRange.ToString()) == 0)
                {
                    temp = pg.min_price_dropdown_elem + "[" + i + "]";
                }

            }


            return temp;

        }
        public string get_xpath_maxprice(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.max_price_dropdown_elem)).Count;

            string temp = "";

            for (int i = 1; i <= count; i++)

            {
                string check = driver.FindElementByXPath(pg.max_price_dropdown_elem + "[" + i + "]").Text.ToString().Replace("€", "");
                check = check.Replace(",", "");
                if (check.CompareTo(sp.MaxPriceRange.ToString()) == 0)
                {
                    temp = pg.max_price_dropdown_elem + "[" + i + "]";
                }

            }


            return temp;
        }
        public string get_xpath_minbed(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.min_bed_dropdown_elem)).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                string check = driver.FindElementByXPath(pg.min_bed_dropdown_elem + "[" + i + "]").Text.ToString().Replace(" bedroom", "").Replace("s", "");


                if (check.CompareTo(sp.MinBedroom.ToString()) == 0)
                {
                    temp = pg.min_bed_dropdown_elem + "[" + i + "]";
                }

            }


            return temp;
        }
        public string get_xpath_maxbed(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.max_bed_dropdown_elem)).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                string check = driver.FindElementByXPath(pg.max_bed_dropdown_elem+"[" + i + "]").Text.ToString().Replace(" bedroom", "").Replace("s", "");



                if (check.CompareTo(sp.MaxBedroom.ToString()) == 0)
                {
                    temp = pg.max_bed_dropdown_elem + "[" + i + "]";
                }

            }


            return temp;
        }
        public string get_xpath_minbath(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.min_bathroom_dropdown_elem)).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                string check = driver.FindElementByXPath(pg.min_bathroom_dropdown_elem + "[" + i + "]").Text.ToString().Replace(" bathroom", "").Replace("s", "");


                if (check.CompareTo(sp.MinBathroom.ToString()) == 0)
                {
                    temp = pg.min_bathroom_dropdown_elem + "[" + i + "]";
                }

            }


            return temp;
        }
        public string get_xpath_maxbath(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath(pg.max_bathroom_dropdown_elem)).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                string check = driver.FindElementByXPath(pg.max_bathroom_dropdown_elem+"[" + i + "]").Text.ToString().Replace(" bathroom", "").Replace("s", "");


                if (check.CompareTo(sp.MaxBathroom.ToString()) == 0)
                {
                    temp = pg.max_bathroom_dropdown_elem + "[" + i + "]";
                }

            }


            return temp;
        }

        public string get_xpath_propertytype(ChromeDriver driver)
        {

            int count = driver.FindElements(By.XPath("//*[@id='ptId_ul']/li")).Count;
            string temp = "";

            for (int i = 1; i <= count; i++)
            {
                string check = driver.FindElementByXPath("//*[@id='ptId_ul']/li[" + i + "]/label").Text;


                if (check.CompareTo(sp.Property_type) == 0)
                {
                    temp = "//*[@id='ptId_ul']/li[" + i + "]/label";
                }

            }


            return temp;
        }

    }
}
