using Project2BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Context
{
    public class BurgerMenuContext: DbContext
    {
        /* Category c# kullanacagimiz sinifin ismi
         * Categories ise veritabanindaki tablonun ismi
         */
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<DealOfTheDay> DealOfTheDays { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
    
    
}