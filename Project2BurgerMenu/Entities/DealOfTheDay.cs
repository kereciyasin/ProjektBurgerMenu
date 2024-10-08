using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Entities
{
    public class DealOfTheDay
    {
        public int DealOfTheDayId { get; set; }
        public string Title { get; set; }
        public string DealOfTheDayDescription { get; set; }
        public decimal DealOfTheDayPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}