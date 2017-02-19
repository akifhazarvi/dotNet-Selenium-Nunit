using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daft_web_automation.PageObject
{
    class Page_Object
    {
        public string To_Rent_elem = "//*[@id='main']/div[1]/div[2]/div/div[2]/div/div/div[1]/ul[1]/li[4]/a";
        public string Category_elem = "//*[@id='main']/div[1]/div[2]/div/div[2]/div/div/div[2]/form/div[1]/div/span/span[1]";
        public string Category_dropwown_elem = "/html/body/div[3]/div/span/div/span/ul/li";
        public string choose_area_elem= "//*[@id='main']/div[1]/div[2]/div/div[2]/div/div/div[2]/form/div[2]";
        public string choose_area_dropdown= "//*[@id='choose-an-area']/div/div/div[2]/div";
        public string search_button_elem= "//*[@id='main']/div[1]/div[2]/div/div[2]/div/div/div[2]/form/button";
        public string advance_search_btn = "//html/body/div[11]/div/div[2]/form/fieldset/a";
        public string min_price_elem = "//*[@id='min_price']";
        public string min_price_dropdown_elem = "//*[@id='min_price']/dd/ul/li";
        public string max_price_elem= "//*[@id='max_price']";
        public string max_price_dropdown_elem = "//*[@id='max_price']/dd/ul/li";
        public string min_bed_elem= "//*[@id='min_bed']";
        public string min_bed_dropdown_elem = "//*[@id='min_bed']/dd/ul/li";
        public string max_bed_elem = "//*[@id='max_bed']";
        public string max_bed_dropdown_elem = "//*[@id='max_bed']/dd/ul/li";
        public string min_bathroom_elem= "//*[@id='min_bath']";
        public string min_bathroom_dropdown_elem = "//*[@id='min_bath']/dd/ul/li";
        public string max_bathroom_elem = "//*[@id='max_bath']";
        public string max_bathroom_dropdown_elem = "//*[@id='max_bath']/dd/ul/li";
        public string property_type_elem = "//*[@id='ptId_select']";
        public string propertu_type_dropown_elem = "//*[@id='ptId_ul']/li[4]/label";
        public string advance_search_btn_elem = "//*[@id='advanced-container']/form/span/div[19]/span[2]/input";
        public string price_info_elem= "//*[@id='sr_content']/tbody/tr/td[1]/div[2]/div[3]/div/strong";
        public string propertytype_elem= "//*[@id='sr_content']/tbody/tr/td[1]/div[2]/div[3]/div/ul/li[1]";
        public string number_bed_elem = "//*[@id='sr_content']/tbody/tr/td[1]/div[2]/div[3]/div/ul/li[2]";
        public string number_bath_elem= "//*[@id='sr_content']/tbody/tr/td[1]/div[2]/div[3]/div/ul/li[3]";
       

    }
}
