using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Globalization;
using System.Drawing;

using System.Net.Mail;
using System.Net;
using Daft_web_automation.HelperMethod;
using Daft_web_automation.PageObject;
using static Daft_web_automation.Common_Objects;
using System.Threading;
using System.Text.RegularExpressions;
using OpenQA.Selenium;

namespace Daft_web_automation
{
    [TestFixture]
    public class Search_Test
    {
        //Intializing the objects
        ChromeDriver driver = new ChromeDriver();
        Shared_data obj = new Shared_data();
        Common_Helper ch = new Common_Helper();
        Page_Object pg = new Page_Object();
        Searchparem sp = new Searchparem();
        Search_result sr = new Search_result();



        //function to return digit from string
        public int get_digit(string value)
        {
            string resultString = Regex.Match(value, @"\d+").Value;


            return Int32.Parse(resultString);

        }
        //Setting up the url
        public void set_url()
        {
            obj.url = "http://www.daft.ie/";


        }



        [Test]
        [Category("daft")]

        public void daft_search_test()
        {
            try
            {
                //Intiallizing the url before the test.
                set_url();
               
                // Adding url in driver to open it in browser
                driver.Navigate().GoToUrl(obj.url);

                //Selection category 
                ch.clickOn(driver, pg.To_Rent_elem);
                Thread.Sleep(2000);

                //Selecting Country/city
                ch.clickOn(driver, pg.Category_elem);
                ch.clickOn(driver, ch.get_xpath_country(driver));

                Thread.Sleep(2000);
                //Selecting area in specific country
                ch.clickOn(driver, pg.choose_area_elem);
                ch.clickOn(driver, ch.get_xpath_area(driver));
                //Taking screenShot
                ch.take_screenshot(driver, "Homepage.png");

                //Clicking on search button
                ch.clickOn(driver, pg.search_button_elem);



                //Taking screenshot
                ch.take_screenshot(driver, "SearchResult.png");
                
                //Clicking on advance search button using css selector
                driver.FindElementByCssSelector("body>div.tabs-container>div>div.tab-content>form>fieldset>a").Click();



                //Selecting min price
                ch.clickOn(driver, pg.min_price_elem);
                ch.clickOn(driver, ch.get_xpath_minprice(driver));
                //Selecting max price 
                ch.clickOn(driver, pg.max_price_elem);
                ch.clickOn(driver, ch.get_xpath_maxprice(driver));

               //Selecting minimum bedroom
                ch.clickOn(driver, pg.min_bed_elem);
                ch.clickOn(driver,ch.get_xpath_minbed(driver));
                //Selecting maximum bedrooms
                ch.clickOn(driver, pg.max_bed_elem);
                ch.clickOn(driver, ch.get_xpath_maxbed(driver));
                //Selecting minimum bathroom
                ch.clickOn(driver, pg.min_bathroom_elem);
                ch.clickOn(driver, ch.get_xpath_minbath(driver));
                //Selecting maximum bathrooms
                ch.clickOn(driver, pg.max_bathroom_elem);
                ch.clickOn(driver, ch.get_xpath_maxbath(driver));
                //Selecting property type
                ch.clickOn(driver, pg.property_type_elem);
                ch.clickOn(driver,ch.get_xpath_propertytype(driver));
                //Taking screenshot
                ch.take_screenshot(driver, "AdvanceSearch.png");
                //Clicking on search button
                ch.clickOn(driver, pg.advance_search_btn_elem);

                //setting up the values need to be tested or verified.
                sr.propertytype = driver.FindElementByXPath(pg.propertytype_elem).Text.Replace("|", "");
                sr.bed = driver.FindElementByXPath(pg.number_bed_elem).Text;
                sr.bath = driver.FindElementByXPath(pg.number_bath_elem).Text;

                //Taking screenshot
                ch.take_screenshot(driver, "AdvanceSearchResult.png");
           


                //Using Assertion operation to verify the actual values and expected values
                Assert.AreEqual(sp.Property_type.ToLower(), sr.propertytype.ToLower());
                Assert.GreaterOrEqual(get_digit(sr.bed), sp.MinBedroom);
                Assert.LessOrEqual(get_digit(sr.bed), sp.MaxBedroom);

                Assert.GreaterOrEqual(get_digit(sr.bath), sp.MinBathroom);
                Assert.LessOrEqual(get_digit(sr.bath), sp.MaxBathroom);

                //Closeing the driver
                driver.Quit();

            }
            catch(Exception e1)
            {
                Console.WriteLine(e1);
                Assert.Fail("Exception! Check the test logs!");
                driver.Quit();
            }










            }
    }
   
       

    }

