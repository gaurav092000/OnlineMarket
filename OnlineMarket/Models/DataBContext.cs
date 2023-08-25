using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineMarket.Models
{
    public class DataBContext :DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> products { get; set; }

        public DbSet<User>  users { get; set; } 


    }
}