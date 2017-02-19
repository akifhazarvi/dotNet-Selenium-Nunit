using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daft_web_automation
{
    class Common_Objects
    {
        // Creating a class whose attributes wiill be seach parameters.
        public class Searchparem
        {
            public string Category = "to rent";
            public string City_country= "Dublin City";
            public string City_area = "Dublin 1";
            public int MaxPriceRange = 1000;
            public int MinPriceRange = 200;
            public int MaxBedroom = 2;

            public int MinBedroom = 1;
            public int MinBathroom = 1;
            public int MaxBathroom = 1;
            public string Property_type = "Flat to rent";
           
        }
        public class Shared_data
        {
            public string url { get; set; }
        }

        //Class for search result
        public class Search_result
        {
            public string bed { get; set; }
            public string bath { get; set; }
            public string propertytype { get; set; }
        }



    }
}
